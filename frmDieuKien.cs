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
    public partial class frmDieuKien : Form
    {
        public frmDieuKien()
        {
            InitializeComponent();
        }
        private Database db;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "insertdieukien";
            if (cbbMonHocTruoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học tiên quyết");
            }
            if (cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString()
            });
            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc_truoc",
                value = cbbMonHocTruoc.SelectedValue.ToString()
            });
            var kq = db.ExeCute(sql, lst);
            if (kq==1)
            {
                MessageBox.Show("Thêm điều kiện mới thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm điều kiện mới thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDieuKien_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter(){
                    key = "@tukhoa",
                    value=""
                }
            };
            cbbMonhoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc";
            cbbMonhoc.ValueMember = "mamonhoc";
            cbbMonhoc.SelectedIndex = -1;
            cbbMonHocTruoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonHocTruoc.DisplayMember = "tenmonhoc";
            cbbMonHocTruoc.ValueMember = "mamonhoc";
            cbbMonHocTruoc.SelectedIndex = -1;
        }
    }
}
