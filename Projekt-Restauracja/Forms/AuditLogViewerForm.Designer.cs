namespace Projekt_Restauracja.Forms
{
    partial class AuditLogViewerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Button btnViewAuditLog;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // --- HEADER PANEL ---
            headerPanel = new System.Windows.Forms.Panel();
            headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 54;

            lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Podgląd Logów";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblHeader.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);

            headerPanel.Controls.Add(lblHeader);

            // --- DATA GRID VIEW ---
            dataGridViewLogs = new System.Windows.Forms.DataGridView();
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewLogs.BackgroundColor = System.Drawing.Color.FromArgb(25, 27, 32);
            dataGridViewLogs.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dataGridViewLogs.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            dataGridViewLogs.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewLogs.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            dataGridViewLogs.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewLogs.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 37, 44);
            dataGridViewLogs.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewLogs.EnableHeadersVisualStyles = false;
            dataGridViewLogs.RowHeadersVisible = false;
            dataGridViewLogs.AllowUserToAddRows = false;
            dataGridViewLogs.AllowUserToDeleteRows = false;
            dataGridViewLogs.AllowUserToOrderColumns = true;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.MultiSelect = false;
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // --- BUTTON ---
            btnViewAuditLog = new System.Windows.Forms.Button();
            btnViewAuditLog.Name = "btnViewAuditLog";
            btnViewAuditLog.Text = "Pokaż logi";
            btnViewAuditLog.Height = 38;
            btnViewAuditLog.Dock = DockStyle.Bottom;
            btnViewAuditLog.Margin = new Padding(0, 8, 0, 8);
            btnViewAuditLog.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            btnViewAuditLog.FlatStyle = FlatStyle.Flat;
            btnViewAuditLog.FlatAppearance.BorderSize = 0;
            btnViewAuditLog.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            btnViewAuditLog.ForeColor = System.Drawing.Color.White;
            btnViewAuditLog.Cursor = Cursors.Hand;
            btnViewAuditLog.Click += new System.EventHandler(this.btnViewAuditLog_Click);

            // --- FORM PROPERTIES ---
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(dataGridViewLogs);
            this.Controls.Add(btnViewAuditLog);
            this.Controls.Add(headerPanel);
            this.Text = "Podgląd Logów";
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            this.ResumeLayout(false);
        }
    }
}
