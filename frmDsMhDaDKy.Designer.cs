namespace ABD
{
    partial class frmDsMhDaDKy
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
            this.dgvDSMHDDKy = new System.Windows.Forms.DataGridView();
            this.malophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDangKyMoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDDKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSMHDDKy
            // 
            this.dgvDSMHDDKy.AllowUserToAddRows = false;
            this.dgvDSMHDDKy.AllowUserToDeleteRows = false;
            this.dgvDSMHDDKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMHDDKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHDDKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHDDKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malophoc,
            this.tenmonhoc,
            this.sotinchi,
            this.tietbatdau,
            this.tietketthuc,
            this.thu,
            this.gvien,
            this.daketthuc});
            this.dgvDSMHDDKy.Location = new System.Drawing.Point(1, 96);
            this.dgvDSMHDDKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSMHDDKy.MultiSelect = false;
            this.dgvDSMHDDKy.Name = "dgvDSMHDDKy";
            this.dgvDSMHDDKy.ReadOnly = true;
            this.dgvDSMHDDKy.RowHeadersWidth = 51;
            this.dgvDSMHDDKy.RowTemplate.Height = 24;
            this.dgvDSMHDDKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHDDKy.Size = new System.Drawing.Size(929, 354);
            this.dgvDSMHDDKy.TabIndex = 0;
            // 
            // malophoc
            // 
            this.malophoc.DataPropertyName = "malophoc";
            this.malophoc.HeaderText = "Mã lớp học";
            this.malophoc.MinimumWidth = 6;
            this.malophoc.Name = "malophoc";
            this.malophoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "sotinchi";
            this.sotinchi.HeaderText = "Số tín chỉ";
            this.sotinchi.MinimumWidth = 6;
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.ReadOnly = true;
            // 
            // tietbatdau
            // 
            this.tietbatdau.DataPropertyName = "tietbatdau";
            this.tietbatdau.HeaderText = "Tiết bắt đầu";
            this.tietbatdau.MinimumWidth = 6;
            this.tietbatdau.Name = "tietbatdau";
            this.tietbatdau.ReadOnly = true;
            // 
            // tietketthuc
            // 
            this.tietketthuc.DataPropertyName = "tietketthuc";
            this.tietketthuc.HeaderText = "Tiết kết thúc";
            this.tietketthuc.MinimumWidth = 6;
            this.tietketthuc.Name = "tietketthuc";
            this.tietketthuc.ReadOnly = true;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Thứ";
            this.thu.MinimumWidth = 6;
            this.thu.Name = "thu";
            this.thu.ReadOnly = true;
            // 
            // gvien
            // 
            this.gvien.DataPropertyName = "gvien";
            this.gvien.HeaderText = "Giáo viên";
            this.gvien.MinimumWidth = 6;
            this.gvien.Name = "gvien";
            this.gvien.ReadOnly = true;
            // 
            // daketthuc
            // 
            this.daketthuc.DataPropertyName = "tinhtrang";
            this.daketthuc.HeaderText = "Tình trạng";
            this.daketthuc.MinimumWidth = 6;
            this.daketthuc.Name = "daketthuc";
            this.daketthuc.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khoá";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(508, 36);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(183, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(697, 35);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 24);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDangKyMoi
            // 
            this.btnDangKyMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyMoi.Location = new System.Drawing.Point(807, 34);
            this.btnDangKyMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyMoi.Name = "btnDangKyMoi";
            this.btnDangKyMoi.Size = new System.Drawing.Size(104, 24);
            this.btnDangKyMoi.TabIndex = 4;
            this.btnDangKyMoi.Text = "Đăng ký mới";
            this.btnDangKyMoi.UseVisualStyleBackColor = true;
            this.btnDangKyMoi.Click += new System.EventHandler(this.btnDangKyMoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABD.Properties.Resources.banner_uit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmDsMhDaDKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangKyMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSMHDDKy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDsMhDaDKy";
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.frmDsMhDaDKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDDKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMHDDKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDangKyMoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn daketthuc;
    }
}