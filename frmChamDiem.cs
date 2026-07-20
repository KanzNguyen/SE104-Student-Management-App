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
    public partial class frmChamDiem : Form
    {
        public frmChamDiem(string malh)
        {
            this.malh = malh;
            InitializeComponent();
        }
        private string malh;
        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            LoadDSD();
        }

        private void LoadDSD()
        {
            List<CustomParameter> firstPara = new List<CustomParameter>();

            firstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malh
            });
            dgvChamDiem.DataSource = new Database().SelectData("SelectDiem", firstPara);
            // đặt tên cột


        }

        private void dgvChamDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvChamDiem.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                
                //Cần truyền mã sinh viên này vào form sinh viên
                new frmUpdateDiem(msv,malh).ShowDialog();
                //MessageBox.Show("Mã sinh viên:" + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());

                //Sau khi form frmSinhVien đc đóng lại
                //Cần load lại danh sách sinh viên
                LoadDSD();
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgvChamDiem.Rows.Count > 0) 
            {
                Microsoft.Office.Interop.Excel.Application xceApp = new Microsoft.Office.Interop.Excel.Application();
                xceApp.Application.Workbooks.Add(Type.Missing);
                for(int i=1;i<dgvChamDiem.Columns.Count+1;i++) 
                {
                    xceApp.Cells[1, i] = dgvChamDiem.Columns[i - 1].HeaderText;
                }
                for(int i=0;i<dgvChamDiem.Rows.Count; i++)
                {
                    for(int j=0;j<dgvChamDiem.Columns.Count;j++)
                    {
                        xceApp.Cells[i + 2, j + 1] = dgvChamDiem.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xceApp.Columns.AutoFit();
                xceApp.Visible = true;

            }
        }

        private void dgvChamDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
