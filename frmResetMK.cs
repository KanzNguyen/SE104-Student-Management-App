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
    public partial class frmResetMK : Form
    {
        public frmResetMK()
        {
            
            InitializeComponent();
        }
        private Database db;
        private void frmResetMK_Load(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string masv;
        
        private void btnreset_Click(object sender, EventArgs e)
        {
            masv=txtmasv.Text;
            db= new Database();
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            var rs = new Database().ExeCute("resetmk", lst);
            if (rs == 1)
            {
                
                    MessageBox.Show("Reset mật khẩu thành công");
                
                this.Dispose();
            }
            else
            {
                MessageBox.Show( "Mã sinh viên không hợp lệ");
            }


        }
    }
}
