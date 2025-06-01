using Projekt_Restauracja.Forms;
using Projekt_Restauracja.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_Restauracja
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();

            if (Session.CurrentUser == null || Session.CurrentUser.Role != "Admin")
            {
                btnAddUser.Enabled = false;
                btnEditUser.Enabled = false;
                btnDeleteUser.Enabled = false;
                MessageBox.Show("Tylko administrator może zarządzać użytkownikami.", "Brak dostępu", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new RestaurantContext())
            {
                dataGridViewUsers.DataSource = context.Users
                    .Select(u => new
                    {
                        u.UserId,
                        u.Username,
                        u.Role
                    })
                    .ToList();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null || Session.CurrentUser.Role != "Admin")
            {
                MessageBox.Show("Brak uprawnień. Tylko administrator może zarządzać użytkownikami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addForm = new AddEditUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                using (var context = new RestaurantContext())
                {
                    if (context.Users.Any(u => u.Username == addForm.Username))
                    {
                        MessageBox.Show("Użytkownik o tej nazwie już istnieje!");
                        return;
                    }

                    var salt = PasswordHelper.GenerateSalt();
                    var hash = PasswordHelper.HashPassword(addForm.Password, salt);
                    var user = new User
                    {
                        Username = addForm.Username,
                        PasswordHash = hash,
                        Salt = salt,
                        Role = addForm.Role
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    AuditLogger.Log("Dodano użytkownika", $"Nazwa: {user.Username}, Rola: {user.Role}");
                }
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null || Session.CurrentUser.Role != "Admin")
            {
                MessageBox.Show("Brak uprawnień. Tylko administrator może zarządzać użytkownikami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika do edycji.");
                return;
            }
            int userId = (int)dataGridViewUsers.SelectedRows[0].Cells["UserId"].Value;

            using (var context = new RestaurantContext())
            {
                var user = context.Users.Find(userId);
                if (user == null)
                {
                    MessageBox.Show("Nie znaleziono użytkownika.");
                    return;
                }

                var editForm = new AddEditUserForm(user.Username, user.Role);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    user.Role = editForm.Role;

                    if (!string.IsNullOrEmpty(editForm.Password))
                    {
                        var salt = PasswordHelper.GenerateSalt();
                        user.PasswordHash = PasswordHelper.HashPassword(editForm.Password, salt);
                        user.Salt = salt;
                    }

                    context.SaveChanges();
                    AuditLogger.Log("Edytowano użytkownika", $"Nazwa: {user.Username}, Nowa rola: {user.Role}");
                    LoadUsers();
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null || Session.CurrentUser.Role != "Admin")
            {
                MessageBox.Show("Brak uprawnień. Tylko administrator może zarządzać użytkownikami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika do usunięcia.");
                return;
            }
            int userId = (int)dataGridViewUsers.SelectedRows[0].Cells["UserId"].Value;

            if (Session.CurrentUser != null && Session.CurrentUser.UserId == userId)
            {
                MessageBox.Show("Nie można usunąć aktualnie zalogowanego użytkownika.");
                return;
            }

            if (MessageBox.Show("Czy na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var context = new RestaurantContext())
                {
                    var user = context.Users.Find(userId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        AuditLogger.Log("Usunięto użytkownika", $"Nazwa: {user.Username}, Rola: {user.Role}");
                        LoadUsers();
                    }
                }
            }
        }
    }
}
