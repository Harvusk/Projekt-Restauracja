using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt_Restauracja.Forms
{
    partial class AnalyticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cmbAnalyticsType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
        private System.Windows.Forms.Panel panelContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // HEADER PANEL
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPanel.BackColor = Color.FromArgb(30, 33, 39);
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 58;

            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeader.Text = "Analytics Dashboard";
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            this.lblHeader.Padding = new Padding(18, 0, 0, 0);

            this.headerPanel.Controls.Add(this.lblHeader);

            // CONTENT PANEL
            this.panelContent = new Panel();
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.BackColor = Color.FromArgb(25, 27, 32);

            // ComboBox: Analytics Type
            this.cmbAnalyticsType = new ComboBox();
            this.cmbAnalyticsType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAnalyticsType.Font = new Font("Segoe UI", 12F);
            this.cmbAnalyticsType.Items.AddRange(new object[] {
                "Największe Obłożenie",
                "Najpopularniejsze dania",
                "Utarg"
            });
            this.cmbAnalyticsType.Location = new Point(32, 18);
            this.cmbAnalyticsType.Size = new Size(320, 29);
            this.cmbAnalyticsType.SelectedIndexChanged += new EventHandler(this.cmbAnalyticsType_SelectedIndexChanged);
            this.cmbAnalyticsType.BackColor = Color.FromArgb(35, 37, 44);
            this.cmbAnalyticsType.ForeColor = Color.White;
            this.cmbAnalyticsType.FlatStyle = FlatStyle.Flat;

            // Chart: Analytics
            this.chartAnalytics = new Chart();
            this.chartAnalytics.Name = "chartAnalytics";
            this.chartAnalytics.Size = new Size(710, 340);
            this.chartAnalytics.Location = new Point(32, 60);
            this.chartAnalytics.BackColor = Color.FromArgb(32, 34, 40);

            var chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.FromArgb(32, 34, 40);
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            this.chartAnalytics.ChartAreas.Add(chartArea);

            this.chartAnalytics.Palette = ChartColorPalette.SeaGreen;
            this.chartAnalytics.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Add controls to content panel
            this.panelContent.SuspendLayout();
            this.panelContent.Controls.Add(this.cmbAnalyticsType);
            this.panelContent.Controls.Add(this.chartAnalytics);
            this.panelContent.ResumeLayout(false);

            // Set up the form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 480);
            this.BackColor = Color.FromArgb(25, 27, 32);
            this.Font = new Font("Segoe UI", 11F);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AnalyticsForm";
            this.Text = "Analytics Dashboard";

            this.ResumeLayout(false);
        }
    }
}
