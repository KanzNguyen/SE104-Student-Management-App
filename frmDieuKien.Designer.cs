namespace ABD
{
    partial class frmDieuKien
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
            this.cbbMonHocTruoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbbMonhoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbMonHocTruoc
            // 
            this.cbbMonHocTruoc.FormattingEnabled = true;
            this.cbbMonHocTruoc.Location = new System.Drawing.Point(139, 81);
            this.cbbMonHocTruoc.Name = "cbbMonHocTruoc";
            this.cbbMonHocTruoc.Size = new System.Drawing.Size(310, 24);
            this.cbbMonHocTruoc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Môn học trước";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(237, 124);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(139, 124);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbMonhoc
            // 
            this.cbbMonhoc.FormattingEnabled = true;
            this.cbbMonhoc.Location = new System.Drawing.Point(139, 28);
            this.cbbMonhoc.Name = "cbbMonhoc";
            this.cbbMonhoc.Size = new System.Drawing.Size(310, 24);
            this.cbbMonhoc.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Môn học";
            // 
            // frmDieuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 195);
            this.Controls.Add(this.cbbMonHocTruoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbMonhoc);
            this.Controls.Add(this.label1);
            this.Name = "frmDieuKien";
            this.Text = "Thêm điều kiện môn học tiên quyết";
            this.Load += new System.EventHandler(this.frmDieuKien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbMonHocTruoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbbMonhoc;
        private System.Windows.Forms.Label label1;
    }
}