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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        public string tendangnhap = "";
        public string matkhau = "";
        public string loaitk = "";
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản"); return;
            }
            if (string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Tên đăng nhập không được bỏ trống"); return;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không được bỏ trống"); return;
            }

            tendangnhap = txtTendangnhap.Text;
            matkhau = txtMatkhau.Text;

            
            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            //MessageBox.Show(loaitk);
            #endregion
   
            List<CustomParameter> lst = new List<CustomParameter>()
            { 
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = tendangnhap
                },
                new CustomParameter() 
                { 
                    key = "@matkhau",
                    value = matkhau
                }
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            } 
                
           
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
