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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f=new frmDSSV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f=new frmDSMH();    
            AddForm (f);    
        }

        private void giaoVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSGV f=new frmDSGV();
            AddForm(f);
        }

        private void resetmatkhau_Click(object sender, EventArgs e)
        {
            frmResetMK f= new frmResetMK();
            f.Show();
        }



        private string taikhoan;
        private string loaitk;

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            var fn = new frmDangnhap();
            fn.ShowDialog(); //Load form đăng nhập nè
            
            //lay tai khoan de dang nhap
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                quanLyLopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
                lyLichSinhVienToolStripMenuItem.Visible = false;
            }  else
            {
                quanLiToolStripMenuItem.Visible = false;
                resetmatkhau.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    chucNangToolStripMenuItem.Visible = false;
                    dieuKienToolStripMenuItem.Visible = false;
                    lyLichSinhVienToolStripMenuItem.Visible = false;
                }
                else
                {
                    quanLyLopToolStripMenuItem.Visible = false;
                    dieuKienToolStripMenuItem.Visible = false;
                }
            }

            frmWelcome f = new frmWelcome();   
            AddForm(f);
            menuStrip1.Show();
            this.Show();
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsLopHoc f=new frmDsLopHoc();   
            AddForm(f);
        }
        /*
        private void dangKyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDsMhDaDKy(taikhoan);
            AddForm(f);

        }
        */

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmKetQuaHocTap(taikhoan);
            AddForm(f);
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDsMhDaDKy(taikhoan);
            AddForm(f);
        }

        private void quanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyLop(taikhoan);
            AddForm(f);
        }

        private void frmdoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoiMK(loaitk, taikhoan);
            f.Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMain main = new frmMain();

            //main.Show();
            //this.Close();
            Application.Restart();
        }

        private void dieuKienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsDieuKien f = new frmDsDieuKien();
            AddForm(f);
        }

        private void lyLichSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            var f = new frmLyLichSV(taikhoan);
            AddForm(f);
        }
    }
}
