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
    public partial class frmDsLopHoc : Form
    {
        public frmDsLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDsLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        private void LoadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();   
            LoadDSLH() ;
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                new frmLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                LoadDSLH();
            }
        }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSLH();
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvLopHoc.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp học: " + dgvLopHoc.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        var malh = dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString().ToLower();
                        var sql = "deleteLH";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key="malophoc",
                            value = malh
                        }
                    };
                        var f = new Database().ExeCute(sql, lstPara);
                        if (f == 0)
                        {
                            MessageBox.Show("Không thể xóa lớp còn hoạt động");
                        


                        }
                        else
                        {
                            MessageBox.Show("Xoá lớp học thành công");
                        }
                        LoadDSLH();
                    }
                }
            }
        }
    }
}
