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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> firstPara = new List<CustomParameter>();
            firstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, firstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // ý tưởng: khi double click vào sinh viên trên datagridview
            // sẽ hiện ra form cập nhật thông tin sinh viên
            // để cập nhật được sinh viên
            // ta cần lấy được mã sinh viên
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                //Cần truyền mã sinh viên này vào form sinh viên
                new frmGV(mgv).ShowDialog();
                //MessageBox.Show("Mã sinh viên:" + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());

                //Sau khi form frmSinhVien đc đóng lại
                //Cần load lại danh sách sinh viên
                loadDSGV();
            }
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    string mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString().ToLower();
                    string tukhoa = "";
           
                    List<CustomParameter> firstPara = new List<CustomParameter>();
                    firstPara.Add(new CustomParameter()
                    {
                        key = "@magiaovien",
                        value = mgv
                    });
                    firstPara.Add(new CustomParameter()
                    {
                        key = "@tukhoa",
                        value = tukhoa
                    });
                    dgvTemp.DataSource = new Database().SelectData("tracuulop", firstPara);
                    if (dgvTemp.Rows.Count > 1)
                    {
                        MessageBox.Show("Giáo viên " + dgvDSGV.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + " vẫn còn lớp đang hoạt động.", "Không thể xoá");
                        return;
                    }

                    if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên: " + dgvDSGV.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString().ToLower();
                        var sql = "deleteGV";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key="magiaovien",
                            value = maGV
                        }
                    };
                        new Database().ExeCute(sql, lstPara);

                        MessageBox.Show("Xóa giáo viên thành công");
                        loadDSGV();
                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}