using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv; //truyền lại mã sinh viên khi form chạy
            InitializeComponent();
        }
        private string msv;

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv)) //nếu mã sinh viên không có -> thêm mới sinh viên
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                //lấy thông tin chi tiết của một sinh viên dựa vào msv
                //msv là mã sinh viên đã được truyền vào từ form dssv
                var r = new Database().Select("selectSV '" + msv + "'");
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào component của form
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                rbtNam.Checked = r["gtinh"].ToString() == "1" ? true : false;
                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //button btnLuu sẽ xử lý 1 trong 2 tình huống
            //trường hợp 1: nếu mã sinh viên không có giá trị -> thêm mới sinh viên
            //trường hợp 2: nếu mã sinh viên có giá trị -> cập nhật thông tin sinh viên
            /*
             ý tưởng: cho dù thêm mới hay cập nhật
            thì đều ần các giá trị: họ, tên đệm, tên, ngày sinh, giới tính
            quê quán, địa chỉ, số điện thoại, email => các giá trị dùng cho cả 2 trường hợp
            riêng cập nhật sinh viên cần quan tâm tới mã sinh viên
             */
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            //vì ngày sinh ở masketbox, set theo dd/mm/yy
            //nhưng trong sql lại lưu dưới dạng yy/mm/dd
            // => cần chuyển sang yy/mm/dd
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select(); // trỏ chuột về mtbNgaysinh
                return;
            }

            string gioitinh = rbtNam.Checked ? "1" : "0"; //toán tử 3 ngôi
            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            //khai báo một danh sách tham số = class CustomParameter
            List<CustomParameter> firstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV"; //gọi procedure thêm mới sinh viên

            }
            else
            {
                sql = "updateSV"; //gọi procedure cập nhật sinh viên
                firstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            firstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });
            var rs = new Database().ExeCute(sql, firstPara); // truyền câu lệnh sql và danh sách các tham số
            if (rs == 1) //nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(msv)) //nếu thêm mới
                {
                    MessageBox.Show("Thêm mới sinh viên thành công!");
                }
                else //nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                }
                this.Dispose(); //đóng form sau khi thực hiện
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}