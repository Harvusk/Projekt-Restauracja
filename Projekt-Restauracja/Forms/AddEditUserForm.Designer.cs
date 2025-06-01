namespace Projekt_Restauracja
{
    partial class AddEditUserForm
    {
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelFields;
        private System.Windows.Forms.Panel buttonBar;

        private void InitializeComponent()
        {
            // FORM
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.ClientSize = new System.Drawing.Size(410, 320);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.DoubleBuffered = true;
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, this.Width, this.Height, 18, 18));

            // HEADER
            headerPanel = new System.Windows.Forms.Panel();
            headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            headerPanel.Size = new System.Drawing.Size(410, 54);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);

            lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Dodaj / Edytuj użytkownika";
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblHeader.AutoSize = false;
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;

            headerPanel.Controls.Add(lblHeader);

            // ACCENT BAR
            accentBar = new System.Windows.Forms.Panel();
            accentBar.Height = 5;
            accentBar.Dock = System.Windows.Forms.DockStyle.Top;
            accentBar.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);

            // MAIN FIELDS PANEL
            panelFields = new System.Windows.Forms.Panel();
            panelFields.BackColor = Color.Transparent;
            panelFields.Dock = System.Windows.Forms.DockStyle.Top;
            panelFields.Size = new Size(410, 180);

            int left = 38, width = 330, height = 32, spacing = 18;

            // Username
            lblUsername = new System.Windows.Forms.Label();
            lblUsername.Text = "Nazwa użytkownika";
            lblUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblUsername.Location = new Point(left, 10);
            lblUsername.Size = new Size(width, 23);

            txtUsername = new System.Windows.Forms.TextBox();
            txtUsername.Location = new Point(left, 33);
            txtUsername.Size = new Size(width, height);
            txtUsername.MaxLength = 50;
            txtUsername.BackColor = Color.FromArgb(35, 37, 44);
            txtUsername.ForeColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);

            // Password
            lblPassword = new System.Windows.Forms.Label();
            lblPassword.Text = "Hasło";
            lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblPassword.Location = new Point(left, 33 + height + spacing);
            lblPassword.Size = new Size(width, 23);

            txtPassword = new System.Windows.Forms.TextBox();
            txtPassword.Location = new Point(left, 33 + height + spacing + 23);
            txtPassword.Size = new Size(width, height);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.BackColor = Color.FromArgb(35, 37, 44);
            txtPassword.ForeColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);

            // Role
            lblRole = new System.Windows.Forms.Label();
            lblRole.Text = "Rola";
            lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblRole.Location = new Point(left, 33 + 2 * (height + spacing));
            lblRole.Size = new Size(width, 23);

            comboRole = new System.Windows.Forms.ComboBox();
            comboRole.Location = new Point(left, 33 + 2 * (height + spacing) + 23);
            comboRole.Size = new Size(width, height);
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.BackColor = Color.FromArgb(35, 37, 44);
            comboRole.ForeColor = Color.White;
            comboRole.FlatStyle = FlatStyle.Flat;
            comboRole.Font = new Font("Segoe UI", 12F);

            // Add all fields to panel
            panelFields.Controls.Add(lblUsername);
            panelFields.Controls.Add(txtUsername);
            panelFields.Controls.Add(lblPassword);
            panelFields.Controls.Add(txtPassword);
            panelFields.Controls.Add(lblRole);
            panelFields.Controls.Add(comboRole);

            // BUTTON BAR
            buttonBar = new Panel();
            buttonBar.Dock = DockStyle.Bottom;
            buttonBar.Height = 64;
            buttonBar.BackColor = Color.Transparent;

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Size = new Size(134, 38);
            btnOK.Location = new Point(60, 13);
            btnOK.BackColor = Color.FromArgb(0, 158, 96);
            btnOK.ForeColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnOK.Cursor = Cursors.Hand;
            btnOK.Click += new EventHandler(this.btnOK_Click);
            btnOK.MouseEnter += (s, e) => btnOK.BackColor = Color.FromArgb(27, 196, 107);
            btnOK.MouseLeave += (s, e) => btnOK.BackColor = Color.FromArgb(0, 158, 96);

            btnCancel = new Button();
            btnCancel.Text = "Anuluj";
            btnCancel.Size = new Size(134, 38);
            btnCancel.Location = new Point(210, 13);
            btnCancel.BackColor = Color.FromArgb(193, 48, 48);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Click += new EventHandler(this.btnCancel_Click);
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(255, 80, 80);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.FromArgb(193, 48, 48);

            buttonBar.Controls.Add(btnOK);
            buttonBar.Controls.Add(btnCancel);

            // --- ADD ALL PANELS ---
            this.Controls.Add(panelFields);
            this.Controls.Add(accentBar);
            this.Controls.Add(headerPanel);
            this.Controls.Add(buttonBar);
        }

        // --- Helper for rounded corners ---
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
