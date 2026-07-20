using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABD
{
    public partial class frmUpdateDiem : Form
    {
        public frmUpdateDiem(string msv, string mlh)
        {
            this.mlh = mlh;
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private string mlh;
        private void frmUpdateDiem_Load(object sender, EventArgs e)
        {
            var r = new Database().Select("selectDiemSV '" + msv + "', '" + mlh + "'");

            //MessageBox.Show(r[0].ToString());
            //set các giá trị vào component của form
            txtDiemGK.Text = r["diemthilan1"].ToString();
            txtDiemCK.Text = r["diemthilan2"].ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "UpdateDiemSV";
            string diemgk = txtDiemGK.Text;
            string diemck = txtDiemCK.Text;
            try
            {
                int number = int.Parse(txtDiemGK.Text);
                int number1 = int.Parse(txtDiemCK.Text);
                if (number < 0 || number > 10 || number1 < 0 || number1 > 10) 
                {
                    throw new ArgumentOutOfRangeException("Giá trị phải nằm trong khoảng từ 0 đến 10.");
                }

                MessageBox.Show("Giá trị hợp lệ!");
            }
            catch
            {
                MessageBox.Show("Giá trị phải nằm trong khoảng từ 0 đến 10.");
                txtDiemGK.Select();
                txtDiemGK.Select();
                return;
            }
            List<CustomParameter> firstPara = new List<CustomParameter>();
            firstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = mlh
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@diemthilan1",
                value = txtDiemGK.Text
        });
            firstPara.Add(new CustomParameter()
            {
                key = "@diemthilan2",
                value = txtDiemCK.Text
        });

            var rs = new Database().ExeCute(sql, firstPara); // truyền câu lệnh sql và danh sách các tham số
            if (rs == 1) //nếu thực thi thành công
            {

                MessageBox.Show("Cập nhật điểm thành công!");

                this.Dispose(); //đóng form sau khi thực hiện
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        
    }
}
