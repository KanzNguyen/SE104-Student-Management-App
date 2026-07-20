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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";
        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=""
                }
            };
            cbbMonhoc.DataSource = db.SelectData("selectALLMonHoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc";
            cbbMonhoc.ValueMember = "mamonhoc";
            cbbMonhoc.SelectedIndex = -1;
            cbbGiaoVien.DataSource = db.SelectData("selectALLGV", lst);
            cbbGiaoVien.DisplayMember = "hoten";
            cbbGiaoVien.ValueMember = "magiaovien";
            cbbGiaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
                rbtDangHoatDong.Checked = r["daketthuc"].ToString() == "0" ? true : false;
                txtThu.Text = r["thu"].ToString();
                txtTietbatdau.Text = r["tietbatdau"].ToString();
                txtTietketthuc.Text = r["tietketthuc"].ToString();
                txtSoslot.Text = r["soslot"].ToString();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if(cbbGiaoVien.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
            }
            if (cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            if(string.IsNullOrEmpty(malophoc)) 
            {
                sql = "insertlophoc";
                lst.Add(new CustomParameter()
                {
                    key="@nguoitao",
                    value=nguoithuchien
                });
            }
            else
            {
                sql = "updatelophoc";

                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
                lst.Add(new CustomParameter()
                {
                    key = "@daketthuc",
                    value = rbtDaKetThuc.Checked ? "1" : "0"
                });
            }
            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString()
            });
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbbGiaoVien.SelectedValue.ToString()
            });
            
            lst.Add(new CustomParameter()
            {
                key = "@thu",
                value = txtThu.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@tietbatdau",
                value = txtTietbatdau.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@tietketthuc",
                value = txtTietketthuc.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@soslot",
                value = txtSoslot.Text
            }); 
            var kq = db.ExeCute(sql,lst);
            if(kq==1)
            {
                if(string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp thành công");


                }
                else
                {
                    MessageBox.Show("Cập nhật lớp thành công");
                }
                this.Dispose(); 
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
