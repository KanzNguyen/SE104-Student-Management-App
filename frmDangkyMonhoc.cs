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
    public partial class frmDangkyMonhoc : Form
    {
        public frmDangkyMonhoc(string msv)
        {
            this.msv= msv;    
            InitializeComponent();
        }
        private string msv;

        private void frmDangkyMonhoc_Load(object sender, EventArgs e)
        {

           LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";
            dgvDSLH.Columns["mamonhoc"].Visible = false;    
        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key="@masinhvien",
                value=msv
            });
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy",lstPara);
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index >= 0)
            {
               if(DialogResult.Yes==
                MessageBox.Show("Bạn muốn đăng kí học phần [" + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()+"]","Xác nhận đăng ký",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
               )
               {
                    List<CustomParameter> lstPara=new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key="@masinhvien",
                        value=msv
                    });
                    
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });
                    var rs = new Database().ExeCute("[dkyhoc]", lstPara);
                    if (rs==-1)

                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký", "Cảnh báo!!!");
                        return;
                    }
                    if(rs==1)
                    {
                        MessageBox.Show("Đã đăng ký học phần thành công");
                        LoadDSLH();
                    }

                }
            }
            
        }
    }
}
