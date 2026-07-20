namespace ABD
{
    partial class frmDoiMK
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
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(249, 93);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(278, 22);
            this.txtMKCu.TabIndex = 1;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(232, 242);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Lưu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(249, 138);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(278, 22);
            this.txtMKMoi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(249, 188);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(278, 22);
            this.txtNhapLai.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(359, 242);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(661, 342);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
    }
}