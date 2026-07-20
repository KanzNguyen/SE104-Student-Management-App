using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
            SetDataGridViewFont();
        }

        private void SetDataGridViewFont()
        {
            // Set the font for the DataGridView
            //dgvSinhVien.Font = new Font("Arial Unicode MS", 5);
        }


        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private string tukhoa = "";
        private void LoadDSSV()
        {
            List<CustomParameter> firstPara = new List<CustomParameter>();
            tukhoa = txtTukhoa.Text;
            firstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", firstPara);
            
            // đặt tên cột
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
        }
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // ý tưởng: khi double click vào sinh viên trên datagridview
            // sẽ hiện ra form cập nhật thông tin sinh viên
            // để cập nhật được sinh viên
            // ta cần lấy được mã sinh viên
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                //Cần truyền mã sinh viên này vào form sinh viên
                new frmSinhVien(msv).ShowDialog();
                //MessageBox.Show("Mã sinh viên:" + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());

                //Sau khi form frmSinhVien đc đóng lại
                //Cần load lại danh sách sinh viên
                LoadDSSV();
            }

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();//nếu thêm mới sinh viên -> mã sinh viên = NULL
            LoadDSSV(); // Loai lại danh sách sinh viên
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvSinhVien.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh: " + dgvSinhVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        var masv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString().ToLower();
                        var sql = "deleteSV";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key="masinhvien",
                            value = masv
                        }
                    };
                     var rs= new Database().ExeCute(sql, lstPara);

                        if (rs == 0) { MessageBox.Show("Không thể xóa sinh viên"); }
                        else
                        { MessageBox.Show("Xóa sinh viên thành công"); }

                        LoadDSSV();
                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}