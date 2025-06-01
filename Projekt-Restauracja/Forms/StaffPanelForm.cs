using Projekt_Restauracja.Forms;
using Projekt_Restauracja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projekt_Restauracja
{
    public partial class StaffPanelForm : Form
    {
        public StaffPanelForm()
        {
            InitializeComponent();
            datePickerReservations.Value = DateTime.Now;
            LoadReservations();
            datePickerReservations.ValueChanged += (s, e) => LoadReservations();
            btnEditReservation.Click += btnEditReservation_Click;
            btnCancelReservation.Click += btnCancelReservation_Click;
            btnRefreshReservations.Click += btnRefreshReservations_Click;
            btnGenerateTestData.Click += btnGenerateTestData_Click;
            btnGenerateTestData.Visible = Session.CurrentUser?.Role == "Admin";
            btnMenuManagement.Click += btnMenuManagement_Click;
            btnUserManagement.Click += btnUserManagement_Click;
            btnUserManagement.Visible = Session.CurrentUser?.Role == "Admin";
            btnViewAuditLog.Visible = Session.CurrentUser?.Role == "Admin";
            btnViewAuditLog.Click += btnViewAuditLog_Click;
            btnAnalytics.Click += btnAnalytics_Click;
            btnAnalytics.Visible = Session.CurrentUser?.Role == "Admin";
        }
        private void btnGenerateTestData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz dodać testowe dane? To spowoduje chwilowe przeciążenie programu",
                "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
            TestDataGenerator.PopulateReservations();
            LoadReservations();
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            using (var context = new RestaurantContext())
            {
                var analyticsService = new AnalyticsService(context);
                using (var analyticsForm = new Projekt_Restauracja.Forms.AnalyticsForm(analyticsService))
                {
                    analyticsForm.ShowDialog();
                }
            }
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null && Session.CurrentUser.Role == "Admin")
            {
                var userForm = new UserManagementForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Brak uprawnień. Tylko administrator może zarządzać użytkownikami.", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            var menuForm = new Projekt_Restauracja.Forms.MenuManagementForm();
            menuForm.ShowDialog();
        }
        private void LoadReservations()
        {
            var selectedDate = datePickerReservations.Value.Date;
            using (var context = new RestaurantContext())
            {
                var reservations = context.Reservations
                    .Where(r => r.ReservationDate == selectedDate)
                    .Select(r => new
                    {
                        r.Id,
                        r.ReservationNumber,
                        r.CustomerName,
                        r.PhoneNumber,
                        r.ReservationDate,
                        r.ReservationTime,
                        r.TableNumber,
                        r.TotalAmount
                    })
                    .OrderBy(r => r.ReservationTime)
                    .ToList();

                dataGridViewReservations.DataSource = reservations;

                foreach (DataGridViewColumn col in dataGridViewReservations.Columns)
                    Console.WriteLine(col.Name);
            }
            dataGridViewReservations.ClearSelection();
        }
        private void btnRefreshReservations_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }
        private void btnViewAuditLog_Click(object sender, EventArgs e)
        {
            var auditLogForm = new Projekt_Restauracja.Forms.AuditLogViewerForm();
            auditLogForm.ShowDialog();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz rezerwację do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int reservationId = (int)dataGridViewReservations.SelectedRows[0].Cells["Id"].Value;

            using (var context = new RestaurantContext())
            {
                var reservation = context.Reservations.FirstOrDefault(r => r.Id == reservationId);
                if (reservation == null)
                {
                    MessageBox.Show("Nie znaleziono rezerwacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var editForm = new ReservationEditForm(reservation);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    reservation.ReservationTime = editForm.SelectedTime;
                    reservation.TableNumber = editForm.SelectedTable;
                    context.SaveChanges();
                    AuditLogger.Log("Edytowano rezerwację", $"Nr: {reservation.ReservationNumber}, Nowa godzina: {editForm.SelectedTime}, Nowy stolik: {editForm.SelectedTable}");
                    LoadReservations();
                }
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz rezerwację do anulowania.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int reservationId = (int)dataGridViewReservations.SelectedRows[0].Cells["Id"].Value;

            if (MessageBox.Show("Czy na pewno chcesz anulować tę rezerwację?", "Potwierdź",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (var context = new RestaurantContext())
            {
                var reservation = context.Reservations.FirstOrDefault(r => r.Id == reservationId);
                if (reservation != null)
                {
                    var orders = context.Orders.Where(o => o.ReservationId == reservation.Id).ToList();
                    context.Orders.RemoveRange(orders);
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                    AuditLogger.Log("Anulowano rezerwację", $"Nr: {reservation.ReservationNumber}, Klient: {reservation.CustomerName}");
                    LoadReservations();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono rezerwacji do anulowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

