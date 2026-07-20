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
    public partial class frmDoiMK : Form
    {
        public string ltk = "";
        public string tk = "";
        public string mkcu = "";
        public string mkmoi = "";
        public string nhaplai = "";
        public frmDoiMK(string ltk, string tk)
        {
            this.ltk = ltk;
            this.tk = tk;
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            mkcu = txtMKCu.Text;
            if (string.IsNullOrEmpty(mkcu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không được bỏ trống"); return;
            }
            switch (ltk)
            {
                case "Quản trị viên":
                    ltk = "admin";
                    break;
                case "Giáo viên":
                    ltk = "gv";
                    break;
                case "Sinh viên":
                    ltk = "sv";
                    break;
            }
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = ltk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = tk
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = mkcu
                }
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count == 0)
            {
                MessageBox.Show("Sai mật khẩu", "Vui lòng nhập lại mật khẩu");
                return;
            }
            mkmoi = txtMKMoi.Text;
            nhaplai = txtNhapLai.Text;

            #region handle_exceptions
            if (string.IsNullOrEmpty(mkmoi))
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trống", "Vui lòng nhập mật khẩu mới"); return;
            }
            if (string.IsNullOrEmpty(nhaplai))
            {
                MessageBox.Show("Mật khẩu nhập lại không được bỏ trống", "Vui lòng nhập lại mật khẩu mới"); return;
            }
            if (mkmoi.Length > 50)
            {
                MessageBox.Show("Mật khẩu mới không được quá 50 ký tự", "Vui lòng nhập lại mật khẩu mới"); return;
            }
            if (nhaplai.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhập lại không được quá 50 ký tự", "Vui lòng nhập lại"); return;
            }
            #endregion

            if (nhaplai == mkmoi)
            {
                //MessageBox.Show("oke", "oke");
                List<CustomParameter> lst2 = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@loaitaikhoan",
                        value = ltk
                    },
                    new CustomParameter()
                    {
                        key = "@taikhoan",
                        value = tk
                    },
                    new CustomParameter()
                    {
                        key = "@matkhau",
                        value = mkcu
                    },
                    new CustomParameter()
                    {
                        key = "@matkhaumoi",
                        value = mkmoi
                    }
                };
                var rs2 = new Database().SelectData("doimk", lst2);
                MessageBox.Show("Đã thay đổi mật khẩu", "Đổi mật khẩu");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Vui lòng nhập lại");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
