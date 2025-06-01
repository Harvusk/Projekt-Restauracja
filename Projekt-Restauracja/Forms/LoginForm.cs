using Microsoft.EntityFrameworkCore;
using Projekt_Restauracja.Forms;
using Projekt_Restauracja.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_Restauracja
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Podaj nazwę użytkownika i hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new RestaurantContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {

                    bool isValid = false;

                    if (!string.IsNullOrEmpty(user.Salt))
                    {
                        string hash = PasswordHelper.HashPassword(password, user.Salt);
                        isValid = hash == user.PasswordHash;
                    }
                    else
                    {
                        string hash = PasswordHelper.HashPassword(password);
                        isValid = hash == user.PasswordHash;
                    }

                    if (isValid)
                    {
                        Session.CurrentUser = user;
                        this.DialogResult = DialogResult.OK;
                        AuditLogger.Log("Logowanie", $"Użytkownik: {username} zalogowany.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nieprawidłowe hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Użytkownik nie istnieje.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}