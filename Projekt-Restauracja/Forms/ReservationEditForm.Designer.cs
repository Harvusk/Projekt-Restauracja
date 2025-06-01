namespace Projekt_Restauracja
{
    partial class ReservationEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
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
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // --- HEADER PANEL ---
            headerPanel = new System.Windows.Forms.Panel();
            headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 54;

            lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Edycja Rezerwacji";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblHeader.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);

            headerPanel.Controls.Add(lblHeader);

            // --- LABEL: Table ---
            lblTable = new System.Windows.Forms.Label();
            lblTable.Text = "Numer stolika:";
            lblTable.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblTable.Location = new System.Drawing.Point(24, 70);
            lblTable.AutoSize = true;

            // --- COMBOBOX: Table ---
            comboTable = new System.Windows.Forms.ComboBox();
            comboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboTable.Font = new System.Drawing.Font("Segoe UI", 11F);
            comboTable.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            comboTable.ForeColor = System.Drawing.Color.White;
            comboTable.Location = new System.Drawing.Point(150, 66);
            comboTable.Size = new System.Drawing.Size(180, 28);

            // --- LABEL: Time ---
            lblTime = new System.Windows.Forms.Label();
            lblTime.Text = "Godzina:";
            lblTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblTime.Location = new System.Drawing.Point(24, 115);
            lblTime.AutoSize = true;

            // --- COMBOBOX: Time ---
            comboTime = new System.Windows.Forms.ComboBox();
            comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            comboTime.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            comboTime.ForeColor = System.Drawing.Color.White;
            comboTime.Location = new System.Drawing.Point(150, 111);
            comboTime.Size = new System.Drawing.Size(180, 28);

            // --- BUTTON: OK ---
            btnOK = new System.Windows.Forms.Button();
            btnOK.Text = "OK";
            btnOK.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            btnOK.ForeColor = System.Drawing.Color.White;
            btnOK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnOK.Location = new System.Drawing.Point(60, 170);
            btnOK.Size = new System.Drawing.Size(100, 40);
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // --- BUTTON: Cancel ---
            btnCancel = new System.Windows.Forms.Button();
            btnCancel.Text = "Anuluj";
            btnCancel.BackColor = System.Drawing.Color.FromArgb(193, 48, 48);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(190, 170);
            btnCancel.Size = new System.Drawing.Size(100, 40);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // --- FORM PROPERTIES ---
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Controls.Add(headerPanel);
            this.Controls.Add(lblTable);
            this.Controls.Add(comboTable);
            this.Controls.Add(lblTime);
            this.Controls.Add(comboTime);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
            this.Text = "Edycja Rezerwacji";
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
