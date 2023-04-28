
namespace GUI
{
    partial class GUI_DoiMatKhau
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
            this.txtTK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU TÀI KHOẢN:";
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Location = new System.Drawing.Point(157, 9);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(11, 13);
            this.txtTK.TabIndex = 1;
            this.txtTK.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MẬT KHẨU CŨ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MẬT KHẨU MỚI:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKCu.Location = new System.Drawing.Point(127, 79);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(263, 21);
            this.txtMKCu.TabIndex = 4;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKMoi.Location = new System.Drawing.Point(127, 108);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(263, 21);
            this.txtMKMoi.TabIndex = 5;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoiMK.Location = new System.Drawing.Point(155, 135);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(115, 33);
            this.btnDoiMK.TabIndex = 6;
            this.btnDoiMK.Text = "ĐỔI";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Location = new System.Drawing.Point(39, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 31);
            this.panel1.TabIndex = 7;
            // 
            // GUI_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 191);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "GUI_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.GUI_DoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Panel panel1;
    }
}