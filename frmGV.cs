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
    public partial class frmGV : Form
    {
        public frmGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";

        private void frmGV_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                rbtNam.Checked = r["Gioitinh"].ToString() == "1" ? true : false;
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                txtKhoa.Text = r["khoa"].ToString();
                txtHocvi.Text = r["hocvi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiachi.Text = r["diachi"].ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime ngaysinh;
            List<CustomParameter> firstPara = new List<CustomParameter>();
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                firstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateGV";
                firstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi
                });
                firstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });

            }
            firstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTendem.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = rbtNam.Checked ? "1" : "0"
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@khoa",
                value = txtKhoa.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@hocvi",
                value = txtHocvi.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = txtEmail.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienthoai.Text
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = txtDiachi.Text
            });

            var rs = new Database().ExeCute(sql, firstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật mới giáo viên thành công!");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}