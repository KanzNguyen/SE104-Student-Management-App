namespace ABD
{
    partial class frmChamDiem
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
            this.dgvChamDiem = new System.Windows.Forms.DataGridView();
            this.btnexcel = new System.Windows.Forms.Button();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamDiem
            // 
            this.dgvChamDiem.AllowUserToAddRows = false;
            this.dgvChamDiem.AllowUserToDeleteRows = false;
            this.dgvChamDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChamDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.sinhvien,
            this.diemthilan1,
            this.diemthilan2});
            this.dgvChamDiem.Location = new System.Drawing.Point(0, 41);
            this.dgvChamDiem.MultiSelect = false;
            this.dgvChamDiem.Name = "dgvChamDiem";
            this.dgvChamDiem.ReadOnly = true;
            this.dgvChamDiem.RowHeadersWidth = 51;
            this.dgvChamDiem.RowTemplate.Height = 24;
            this.dgvChamDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamDiem.Size = new System.Drawing.Size(800, 409);
            this.dgvChamDiem.TabIndex = 1;
            this.dgvChamDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamDiem_CellContentClick);
            this.dgvChamDiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamDiem_CellDoubleClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexcel.Location = new System.Drawing.Point(0, 0);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(800, 44);
            this.btnexcel.TabIndex = 2;
            this.btnexcel.Text = "Export";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "Mã sinh viên";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            // 
            // sinhvien
            // 
            this.sinhvien.DataPropertyName = "sinhvien";
            this.sinhvien.HeaderText = "Họ tên";
            this.sinhvien.MinimumWidth = 6;
            this.sinhvien.Name = "sinhvien";
            this.sinhvien.ReadOnly = true;
            // 
            // diemthilan1
            // 
            this.diemthilan1.DataPropertyName = "diemthilan1";
            this.diemthilan1.HeaderText = "Điểm giữa kì";
            this.diemthilan1.MinimumWidth = 6;
            this.diemthilan1.Name = "diemthilan1";
            this.diemthilan1.ReadOnly = true;
            // 
            // diemthilan2
            // 
            this.diemthilan2.DataPropertyName = "diemthilan2";
            this.diemthilan2.HeaderText = "Điểm cuối kì";
            this.diemthilan2.MinimumWidth = 6;
            this.diemthilan2.Name = "diemthilan2";
            this.diemthilan2.ReadOnly = true;
            // 
            // frmChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dgvChamDiem);
            this.Name = "frmChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách điểm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamDiem;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan2;
    }
}