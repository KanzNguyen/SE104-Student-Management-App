namespace ABD
{
    partial class frmDsDieuKien
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
            this.dgvDieuKien = new System.Windows.Forms.DataGridView();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc_truoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc_truoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDieuKien
            // 
            this.dgvDieuKien.AllowUserToAddRows = false;
            this.dgvDieuKien.AllowUserToDeleteRows = false;
            this.dgvDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDieuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDieuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.tenmonhoc,
            this.mamonhoc_truoc,
            this.tenmonhoc_truoc,
            this.btnDelete});
            this.dgvDieuKien.Location = new System.Drawing.Point(-51, 77);
            this.dgvDieuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDieuKien.MultiSelect = false;
            this.dgvDieuKien.Name = "dgvDieuKien";
            this.dgvDieuKien.RowHeadersWidth = 51;
            this.dgvDieuKien.RowTemplate.Height = 24;
            this.dgvDieuKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDieuKien.Size = new System.Drawing.Size(1002, 373);
            this.dgvDieuKien.TabIndex = 9;
            this.dgvDieuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDieuKien_CellClick);
            this.dgvDieuKien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDieuKien_CellDoubleClick);
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            // 
            // mamonhoc_truoc
            // 
            this.mamonhoc_truoc.DataPropertyName = "mamonhoc_truoc";
            this.mamonhoc_truoc.HeaderText = "Mã môn học trước";
            this.mamonhoc_truoc.MinimumWidth = 6;
            this.mamonhoc_truoc.Name = "mamonhoc_truoc";
            this.mamonhoc_truoc.ReadOnly = true;
            // 
            // tenmonhoc_truoc
            // 
            this.tenmonhoc_truoc.DataPropertyName = "tenmonhoc_truoc";
            this.tenmonhoc_truoc.HeaderText = "Tên môn học tiên quyết";
            this.tenmonhoc_truoc.MinimumWidth = 6;
            this.tenmonhoc_truoc.Name = "tenmonhoc_truoc";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Location = new System.Drawing.Point(852, 24);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(596, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(141, 22);
            this.txtTimKiem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ khóa";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(752, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABD.Properties.Resources.banner_uit;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmDsDieuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.dgvDieuKien);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmDsDieuKien";
            this.Text = "Danh sách điều kiện";
            this.Load += new System.EventHandler(this.frmDsDieuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDieuKien;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc_truoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc_truoc;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}