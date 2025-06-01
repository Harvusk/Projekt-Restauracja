using System;
using System.Windows.Forms;

namespace Projekt_Restauracja
{
    public partial class AddEditUserForm : Form
    {
        public string Username
        {
            get { return txtUsername.Text.Trim(); }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public string Role
        {
            get { return comboRole.SelectedItem?.ToString(); }
            set { comboRole.SelectedItem = value; }
        }

        public AddEditUserForm()
        {
            InitializeComponent();
            comboRole.Items.AddRange(new string[] { "Admin", "Staff" });
            comboRole.SelectedIndex = 0;
        }

        public AddEditUserForm(string username, string role) : this()
        {
            Username = username;
            comboRole.SelectedItem = role;
            txtUsername.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username) || Username.Length > 50)
            {
                MessageBox.Show("Podaj nazwę użytkownika (do 50 znaków).");
                return;
            }
            if (comboRole.SelectedItem == null)
            {
                MessageBox.Show("Wybierz rolę użytkownika.");
                return;
            }
            if (txtUsername.Enabled && string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Podaj hasło.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}