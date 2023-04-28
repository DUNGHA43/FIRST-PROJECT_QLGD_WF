
namespace GUI
{
    partial class REPORT
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
            this.cryRP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRP
            // 
            this.cryRP.ActiveViewIndex = -1;
            this.cryRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRP.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryRP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRP.Location = new System.Drawing.Point(0, 0);
            this.cryRP.Name = "cryRP";
            this.cryRP.Size = new System.Drawing.Size(762, 458);
            this.cryRP.TabIndex = 0;
            this.cryRP.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 458);
            this.Controls.Add(this.cryRP);
            this.Name = "REPORT";
            this.Text = "REPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.REPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryRP;
    }
}