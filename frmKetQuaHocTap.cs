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
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giáo viên";
            dgvKQHT.Columns["diemthilan1"].HeaderText = "Điểm thi lần 1";
            dgvKQHT.Columns["diemthilan2"].HeaderText = "Điểm thi lần 2";
        }
        private void LoadKQHT()
        {
            List<CustomParameter> firstPara = new List<CustomParameter>();
            firstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", firstPara);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }
    }
}
