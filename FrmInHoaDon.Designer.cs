
namespace Quan_Li_Khach_San_NET
{
    partial class FrmInHoaDon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CRVHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1505, 720);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // CRVHoaDon
            // 
            this.CRVHoaDon.ActiveViewIndex = -1;
            this.CRVHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVHoaDon.Location = new System.Drawing.Point(0, 0);
            this.CRVHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRVHoaDon.Name = "CRVHoaDon";
            this.CRVHoaDon.Size = new System.Drawing.Size(1505, 720);
            this.CRVHoaDon.TabIndex = 1;
            // 
            // FrmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 720);
            this.Controls.Add(this.CRVHoaDon);
            this.Controls.Add(this.crystalReportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInHoaDon";
            this.Load += new System.EventHandler(this.FrmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVHoaDon;
    }
}