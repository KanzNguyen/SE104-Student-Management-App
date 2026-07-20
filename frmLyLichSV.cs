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
    public partial class frmLyLichSV : Form
    {
        public frmLyLichSV(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmLyLichSV_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin lý lịch sinh viên";
            var r = new Database().Select("selectSV '" + msv + "'");
            txtHo.Text = r["ho"].ToString();
            txtTendem.Text = r["tendem"].ToString();
            txtTen.Text = r["ten"].ToString();
            mtbNgaysinh.Text = r["ngsinh"].ToString();
            txtgioiTinh.Text = r["gtinh"].ToString();
            txtQuequan.Text = r["quequan"].ToString();
            txtDiachi.Text = r["diachi"].ToString();
            txtDienthoai.Text = r["dienthoai"].ToString();
            txtEmail.Text = r["email"].ToString();
        }
    }
}
