namespace Projekt_Restauracja
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // LoginForm
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(100, 70);
            this.txtUsername.Size = new System.Drawing.Size(200, 30);
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(100, 120);
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(100, 170);
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Controls
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}