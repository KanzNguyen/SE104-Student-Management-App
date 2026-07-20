namespace ABD
{
    partial class frmLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonhoc = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbGiaoVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtDangHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtDaKetThuc = new System.Windows.Forms.RadioButton();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTietbatdau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTietketthuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoslot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbMonhoc
            // 
            this.cbbMonhoc.FormattingEnabled = true;
            this.cbbMonhoc.Location = new System.Drawing.Point(181, 43);
            this.cbbMonhoc.Name = "cbbMonhoc";
            this.cbbMonhoc.Size = new System.Drawing.Size(310, 24);
            this.cbbMonhoc.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(199, 319);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(337, 319);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.FormattingEnabled = true;
            this.cbbGiaoVien.Location = new System.Drawing.Point(181, 79);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(310, 24);
            this.cbbGiaoVien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giáo viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtDangHoatDong
            // 
            this.rbtDangHoatDong.AutoSize = true;
            this.rbtDangHoatDong.Checked = true;
            this.rbtDangHoatDong.Location = new System.Drawing.Point(189, 279);
            this.rbtDangHoatDong.Name = "rbtDangHoatDong";
            this.rbtDangHoatDong.Size = new System.Drawing.Size(123, 20);
            this.rbtDangHoatDong.TabIndex = 6;
            this.rbtDangHoatDong.TabStop = true;
            this.rbtDangHoatDong.Text = "Đang hoạt động";
            this.rbtDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtDaKetThuc
            // 
            this.rbtDaKetThuc.AutoSize = true;
            this.rbtDaKetThuc.Location = new System.Drawing.Point(337, 279);
            this.rbtDaKetThuc.Name = "rbtDaKetThuc";
            this.rbtDaKetThuc.Size = new System.Drawing.Size(93, 20);
            this.rbtDaKetThuc.TabIndex = 7;
            this.rbtDaKetThuc.TabStop = true;
            this.rbtDaKetThuc.Text = "Đã kết thúc";
            this.rbtDaKetThuc.UseVisualStyleBackColor = true;
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(181, 115);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(211, 22);
            this.txtThu.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Thứ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiết bắt đầu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTietbatdau
            // 
            this.txtTietbatdau.Location = new System.Drawing.Point(181, 152);
            this.txtTietbatdau.Name = "txtTietbatdau";
            this.txtTietbatdau.Size = new System.Drawing.Size(211, 22);
            this.txtTietbatdau.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiết kết thúc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTietketthuc
            // 
            this.txtTietketthuc.Location = new System.Drawing.Point(181, 189);
            this.txtTietketthuc.Name = "txtTietketthuc";
            this.txtTietketthuc.Size = new System.Drawing.Size(211, 22);
            this.txtTietketthuc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSoslot
            // 
            this.txtSoslot.Location = new System.Drawing.Point(181, 225);
            this.txtSoslot.Name = "txtSoslot";
            this.txtSoslot.Size = new System.Drawing.Size(211, 22);
            this.txtSoslot.TabIndex = 9;
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 388);
            this.Controls.Add(this.txtSoslot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTietketthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTietbatdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbtDaKetThuc);
            this.Controls.Add(this.rbtDangHoatDong);
            this.Controls.Add(this.cbbGiaoVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbMonhoc);
            this.Controls.Add(this.label1);
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLopHoc";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMonhoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtDangHoatDong;
        private System.Windows.Forms.RadioButton rbtDaKetThuc;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTietbatdau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTietketthuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoslot;
    }
}