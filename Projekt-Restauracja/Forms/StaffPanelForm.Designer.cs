namespace Projekt_Restauracja
{
    partial class StaffPanelForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker datePickerReservations;
        private System.Windows.Forms.Button btnRefreshReservations;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnGenerateTestData;
        private System.Windows.Forms.Button btnViewAuditLog;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            lblHeader = new Label();
            datePickerReservations = new DateTimePicker();
            btnRefreshReservations = new Button();
            btnEditReservation = new Button();
            btnCancelReservation = new Button();
            btnMenuManagement = new Button();
            btnUserManagement = new Button();
            btnGenerateTestData = new Button();
            btnViewAuditLog = new Button();
            btnAnalytics = new Button();
            dataGridViewReservations = new DataGridView();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(30, 33, 39);
            headerPanel.Controls.Add(lblHeader);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 54);
            headerPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(18, 0, 0, 0);
            lblHeader.Size = new Size(900, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Panel Rezerwacji – Obsługa";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // datePickerReservations
            // 
            datePickerReservations.Font = new Font("Segoe UI", 11F);
            datePickerReservations.Location = new Point(51, 70);
            datePickerReservations.Name = "datePickerReservations";
            datePickerReservations.Size = new Size(200, 27);
            datePickerReservations.TabIndex = 1;
            // 
            // btnRefreshReservations
            // 
            btnRefreshReservations.BackColor = Color.FromArgb(0, 158, 96);
            btnRefreshReservations.Cursor = Cursors.Hand;
            btnRefreshReservations.FlatAppearance.BorderSize = 0;
            btnRefreshReservations.FlatStyle = FlatStyle.Flat;
            btnRefreshReservations.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefreshReservations.ForeColor = Color.White;
            btnRefreshReservations.Location = new Point(20, 106);
            btnRefreshReservations.Name = "btnRefreshReservations";
            btnRefreshReservations.Size = new Size(120, 30);
            btnRefreshReservations.TabIndex = 2;
            btnRefreshReservations.Text = "Odśwież";
            btnRefreshReservations.UseVisualStyleBackColor = false;
            // 
            // btnEditReservation
            // 
            btnEditReservation.BackColor = Color.FromArgb(0, 158, 96);
            btnEditReservation.Cursor = Cursors.Hand;
            btnEditReservation.FlatAppearance.BorderSize = 0;
            btnEditReservation.FlatStyle = FlatStyle.Flat;
            btnEditReservation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditReservation.ForeColor = Color.White;
            btnEditReservation.Location = new Point(708, 70);
            btnEditReservation.Name = "btnEditReservation";
            btnEditReservation.Size = new Size(180, 30);
            btnEditReservation.TabIndex = 3;
            btnEditReservation.Text = "Edytuj rezerwację";
            btnEditReservation.UseVisualStyleBackColor = false;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = Color.FromArgb(193, 48, 48);
            btnCancelReservation.Cursor = Cursors.Hand;
            btnCancelReservation.FlatAppearance.BorderSize = 0;
            btnCancelReservation.FlatStyle = FlatStyle.Flat;
            btnCancelReservation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelReservation.ForeColor = Color.White;
            btnCancelReservation.Location = new Point(708, 106);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(180, 30);
            btnCancelReservation.TabIndex = 4;
            btnCancelReservation.Text = "Anuluj rezerwację";
            btnCancelReservation.UseVisualStyleBackColor = false;
            // 
            // btnMenuManagement
            // 
            btnMenuManagement.BackColor = Color.FromArgb(0, 158, 96);
            btnMenuManagement.Cursor = Cursors.Hand;
            btnMenuManagement.FlatAppearance.BorderSize = 0;
            btnMenuManagement.FlatStyle = FlatStyle.Flat;
            btnMenuManagement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMenuManagement.ForeColor = Color.White;
            btnMenuManagement.Location = new Point(522, 70);
            btnMenuManagement.Name = "btnMenuManagement";
            btnMenuManagement.Size = new Size(180, 30);
            btnMenuManagement.TabIndex = 6;
            btnMenuManagement.Text = "Zarządzaj menu";
            btnMenuManagement.UseVisualStyleBackColor = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(0, 158, 96);
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(522, 106);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(180, 30);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "Zarządzaj personelem";
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnGenerateTestData
            // 
            btnGenerateTestData.BackColor = Color.FromArgb(0, 158, 96);
            btnGenerateTestData.Cursor = Cursors.Hand;
            btnGenerateTestData.FlatAppearance.BorderSize = 0;
            btnGenerateTestData.FlatStyle = FlatStyle.Flat;
            btnGenerateTestData.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerateTestData.ForeColor = Color.White;
            btnGenerateTestData.Location = new Point(336, 106);
            btnGenerateTestData.Name = "btnGenerateTestData";
            btnGenerateTestData.Size = new Size(180, 30);
            btnGenerateTestData.TabIndex = 8;
            btnGenerateTestData.Text = "TEST - Dodaj Klientów";
            btnGenerateTestData.UseVisualStyleBackColor = false;
            // 
            // btnViewAuditLog
            // 
            btnViewAuditLog.BackColor = Color.FromArgb(0, 158, 96);
            btnViewAuditLog.Cursor = Cursors.Hand;
            btnViewAuditLog.FlatAppearance.BorderSize = 0;
            btnViewAuditLog.FlatStyle = FlatStyle.Flat;
            btnViewAuditLog.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnViewAuditLog.ForeColor = Color.White;
            btnViewAuditLog.Location = new Point(336, 70);
            btnViewAuditLog.Name = "btnViewAuditLog";
            btnViewAuditLog.Size = new Size(180, 30);
            btnViewAuditLog.TabIndex = 9;
            btnViewAuditLog.Text = "Pokaż dziennik zdarzeń";
            btnViewAuditLog.UseVisualStyleBackColor = false;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.FromArgb(0, 158, 96);
            btnAnalytics.Cursor = Cursors.Hand;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.Location = new Point(146, 106);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(120, 30);
            btnAnalytics.TabIndex = 5;
            btnAnalytics.Text = "Statystyki";
            btnAnalytics.UseVisualStyleBackColor = false;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.AllowUserToAddRows = false;
            dataGridViewReservations.AllowUserToDeleteRows = false;
            dataGridViewReservations.AllowUserToOrderColumns = true;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservations.BackgroundColor = Color.FromArgb(25, 27, 32);
            dataGridViewReservations.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 37, 44);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 33, 39);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 158, 96);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewReservations.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReservations.EnableHeadersVisualStyles = false;
            dataGridViewReservations.GridColor = Color.FromArgb(60, 60, 60);
            dataGridViewReservations.Location = new Point(20, 160);
            dataGridViewReservations.MultiSelect = false;
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.ReadOnly = true;
            dataGridViewReservations.RowHeadersVisible = false;
            dataGridViewReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservations.Size = new Size(850, 300);
            dataGridViewReservations.TabIndex = 10;
            // 
            // StaffPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(headerPanel);
            Controls.Add(datePickerReservations);
            Controls.Add(btnRefreshReservations);
            Controls.Add(btnEditReservation);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnAnalytics);
            Controls.Add(btnMenuManagement);
            Controls.Add(btnUserManagement);
            Controls.Add(btnGenerateTestData);
            Controls.Add(btnViewAuditLog);
            Controls.Add(dataGridViewReservations);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "StaffPanelForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panel Rezerwacji – Obsługa";
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
        }
        #endregion


    }
}