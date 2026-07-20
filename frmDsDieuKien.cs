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
    public partial class frmDsDieuKien : Form
    {
        public frmDsDieuKien()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void LoadDSDieukien()
        {
            string sql = "SelectAllDieuKien";
            List<CustomParameter> firstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value=tukhoa
                }
            };
            dgvDieuKien.DataSource = new Database().SelectData(sql, firstPara);

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmDieuKien().ShowDialog();
            LoadDSDieukien();
        }

        private void frmDsDieuKien_Load(object sender, EventArgs e)
        {
            LoadDSDieukien();
        }

        private void dgvDieuKien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new frmDieuKien().ShowDialog();
                LoadDSDieukien();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSDieukien();
        }

        private void dgvDieuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDieuKien.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa điều kiện ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        var mamh = dgvDieuKien.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString().ToLower();
                        var mamh_truoc = dgvDieuKien.Rows[e.RowIndex].Cells["mamonhoc_truoc"].Value.ToString().ToLower();
                        var sql = "deleteDieuKien";
                        var lstPara = new List<CustomParameter>();
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@mamonhoc",
                            value = mamh
                        });
                        lstPara.Add(new CustomParameter()
                        {
                            key = "@mamonhoc_truoc",
                            value = mamh_truoc
                        });
                        new Database().ExeCute(sql, lstPara);
                        MessageBox.Show("Xóa điều kiện thành công");
                        LoadDSDieukien();
                    }
                }
            }
        }
    }
}

