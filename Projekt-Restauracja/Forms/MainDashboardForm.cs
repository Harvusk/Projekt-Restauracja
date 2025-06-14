using Projekt_Restauracja.Forms;
using Projekt_Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_Restauracja
{
    public partial class Formularz : Form
    {
        private int selectedTable = 0;

        public Formularz()
        {
            InitializeComponent();

            imienazwisko.TextChanged += InputFieldsChanged;
            numer_telefonu.TextChanged += InputFieldsChanged;
            data_rezerwacji.ValueChanged += InputFieldsChanged;
            godzina_rezerwacji.SelectedIndexChanged += InputFieldsChanged;

            btnstolik1.Click += btnstolik_Click;
            btnstolik2.Click += btnstolik_Click;
            btnstolik3.Click += btnstolik_Click;
            btnstolik4.Click += btnstolik_Click;
            btnstolik5.Click += btnstolik_Click;
            btnstolik6.Click += btnstolik_Click;

            menu_dan.CellValueChanged += menu_dan_CellValueChanged;
            menu_dan.CellBeginEdit += menu_dan_CellBeginEdit;
            menu_dan.CellClick += menu_dan_grid_CellClick;
            btnrezerwacja.Click += btnrezerwacja_Click;
            btnStaffLogin.Click += btnStaffLogin_Click;
        }

        private void Formularz_Load(object sender, EventArgs e)
        {
            RestaurantContext.InitializeDatabase();
            godzina_rezerwacji.Items.Clear();
            godzina_rezerwacji.Items.AddRange(new object[] {
                "Wybierz godzinę      ->", "12:00", "12:45", "13:30", "14:15", "15:00",
                "15:45", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15", "21:00" });

            if (godzina_rezerwacji.Items.Count > 0)
                godzina_rezerwacji.SelectedIndex = 0;

            using (var context = new RestaurantContext())
            {
                if (!context.MenuItems.Any())
                {
                    context.MenuItems.AddRange(new List<MenuItem>
                        {
                            // PIZZE
                            new MenuItem { Name = "Margherita", Price = 45, Category = "PIZZE" },
                            new MenuItem { Name = "Pepperoni", Price = 50, Category = "PIZZE" },
                            new MenuItem { Name = "Al pesto", Price = 55, Category = "PIZZE" },
                            new MenuItem { Name = "Neapolitańska", Price = 50, Category = "PIZZE" },
                            new MenuItem { Name = "Neapolitańska", Price = 50, Category = "PIZZE" },

                            // DANIA GŁÓWNE
                            new MenuItem { Name = "Spaghetti alle Vongole", Price = 45, Category = "DANIA GŁÓWNE" },
                            new MenuItem { Name = "Risotto ai Frutti di Mare", Price = 60, Category = "DANIA GŁÓWNE" },
                            new MenuItem { Name = "Calamari Ripieni", Price = 65, Category = "DANIA GŁÓWNE" },
                            new MenuItem { Name = "Tagliatelle z pesto z jarmużu", Price = 40, Category = "DANIA GŁÓWNE" },
                            new MenuItem { Name = "Caponata", Price = 35, Category = "DANIA GŁÓWNE" },

                            // ZUPY
                            new MenuItem { Name = "Vellutata di Funghi", Price = 28, Category = "ZUPY" },
                            new MenuItem { Name = "Ribollita Toscana", Price = 25, Category = "ZUPY" },
                            new MenuItem { Name = "Acquacotta Maremmana", Price = 30, Category = "ZUPY" },

                            // DESERY
                            new MenuItem { Name = "Tiramisù", Price = 18, Category = "DESERY" },
                            new MenuItem { Name = "Panna Cotta", Price = 16, Category = "DESERY" },
                            new MenuItem { Name = "Cannoli Siciliani", Price = 22, Category = "DESERY" },

                            // NAPOJE
                            new MenuItem { Name = "Woda Perlage", Price = 6, Category = "NAPOJE" },
                            new MenuItem { Name = "Herbata Ice-Tea Lemone", Price = 8, Category = "NAPOJE" },
                            new MenuItem { Name = "Sok Pomarańczowy Świeży", Price = 8, Category = "NAPOJE" },
                            new MenuItem { Name = "Espresso / Caffè", Price = 10, Category = "NAPOJE" },
                            new MenuItem { Name = "Cappuccino", Price = 12, Category = "NAPOJE" }
                        });
                    context.SaveChanges();
                }

                var items = context.MenuItems.OrderBy(m => m.Category).ThenBy(m => m.Name).ToList();
                string lastCategory = null;
                menu_dan.Rows.Clear();
                foreach (var item in items)
                {
                    if (item.Category != lastCategory)
                    {
                        menu_dan.Rows.Add($"🍽️ {item.Category.ToUpper()}", "-", "-");
                        lastCategory = item.Category;
                    }
                    menu_dan.Rows.Add(item.Name, item.Price.ToString("0.00"), "");
                }
            }

            menu_dan.Columns["ilosc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            menu_dan.Columns["cena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            menu_dan.ClearSelection();

            suma_zamowienia.Text = "Suma: 0,00 zł";
            HideAllTables();
        }

        private bool InputValidForTableSelection()
        {
            string name = imienazwisko.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || name.Length > 50 ||
                name.Count(c => c == ' ') != 1 ||
                !name.Replace(" ", "").All(char.IsLetter))
                return false;

            if (numer_telefonu.Text.Length != 9 || !numer_telefonu.Text.All(char.IsDigit))
                return false;

            if (data_rezerwacji.Value.Date < DateTime.Today)
                return false;

            if (godzina_rezerwacji.SelectedIndex <= 0)
                return false;

            return true;
        }

        private bool AllFieldsValid()
        {
            if (!InputValidForTableSelection())
                return false;

            bool hasAnyOrder = false;
            for (int i = 0; i < menu_dan.Rows.Count; i++)
            {
                string qtyStr = menu_dan.Rows[i].Cells["ilosc"].Value?.ToString();
                if (int.TryParse(qtyStr, out int qty) && qty > 0)
                {
                    hasAnyOrder = true;
                    break;
                }
            }
            if (!hasAnyOrder)
                return false;

            return true;
        }

        private void InputFieldsChanged(object sender, EventArgs e)
        {
            if (InputValidForTableSelection())
                ShowAvailableTables();
            else
            {
                HideAllTables();
                selectedTable = 0;
            }
            btnrezerwacja.Enabled = AllFieldsValid() && selectedTable != 0;
        }

        private void ShowAvailableTables()
        {
            HideAllTables();

            DateTime date = data_rezerwacji.Value.Date;
            string time = godzina_rezerwacji.SelectedItem?.ToString()?.Trim();

            List<int> reservedTables;
            using (var context = new RestaurantContext())
            {
                reservedTables = context.Reservations
                    .Where(r => r.ReservationDate == date && r.ReservationTime.Trim() == time)
                    .Select(r => r.TableNumber)
                    .ToList();
            }

            for (int i = 1; i <= 6; i++)
            {
                if (!reservedTables.Contains(i))
                {
                    var btn = GetTableButton(i);
                    btn.Visible = true;
                    btn.Enabled = true;
                    btn.BackColor = System.Drawing.Color.Black;
                }
            }

            if (reservedTables.Contains(selectedTable))
                selectedTable = 0;
        }

        private void HideAllTables()
        {
            btnstolik1.Visible = btnstolik2.Visible = btnstolik3.Visible =
                btnstolik4.Visible = btnstolik5.Visible = btnstolik6.Visible = false;
        }

        private Button GetTableButton(int num)
        {
            switch (num)
            {
                case 1: return btnstolik1;
                case 2: return btnstolik2;
                case 3: return btnstolik3;
                case 4: return btnstolik4;
                case 5: return btnstolik5;
                case 6: return btnstolik6;
                default: return null;
            }
        }

        private void btnstolik_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                var btn = GetTableButton(i);
                if (btn.Visible)
                    btn.BackColor = System.Drawing.Color.Black;
            }

            Button clicked = sender as Button;
            clicked.BackColor = System.Drawing.Color.LightBlue;

            if (clicked == btnstolik1) selectedTable = 1;
            else if (clicked == btnstolik2) selectedTable = 2;
            else if (clicked == btnstolik3) selectedTable = 3;
            else if (clicked == btnstolik4) selectedTable = 4;
            else if (clicked == btnstolik5) selectedTable = 5;
            else if (clicked == btnstolik6) selectedTable = 6;

            btnrezerwacja.Enabled = AllFieldsValid() && selectedTable != 0;
        }

        private void menu_dan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < menu_dan.Rows.Count; i++)
            {
                string priceStr = menu_dan.Rows[i].Cells["cena"].Value?.ToString();
                string qtyStr = menu_dan.Rows[i].Cells["ilosc"].Value?.ToString();
                if (decimal.TryParse(priceStr, out decimal price) &&
                    int.TryParse(qtyStr, out int qty) && qty > 0)
                {
                    sum += price * qty;
                }
            }
            suma_zamowienia.Text = $"Suma: {sum:0.00} zł";
            btnrezerwacja.Enabled = AllFieldsValid() && selectedTable != 0;
        }

        private void menu_dan_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cellValue = menu_dan.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (cellValue != null &&
                (cellValue.StartsWith("🍕") || cellValue.StartsWith("🍝") || cellValue.StartsWith("🥣") || cellValue.StartsWith("🍰") || cellValue.StartsWith("🥤")) &&
                e.ColumnIndex == 2)
            {
                e.Cancel = true;
            }
        }

        private void menu_dan_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                menu_dan.CurrentCell = menu_dan[e.ColumnIndex, e.RowIndex];
                menu_dan.BeginEdit(true);
            }
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var staffPanel = new StaffPanelForm();
                    staffPanel.ShowDialog();
                }
            }
        }

        private void btnrezerwacja_Click(object sender, EventArgs e)
        {
            if (!AllFieldsValid() || selectedTable == 0)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola i wybrać stolik!");
                return;
            }

            string name = imienazwisko.Text.Trim();
            string phone = numer_telefonu.Text;
            DateTime date = data_rezerwacji.Value.Date;
            string time = godzina_rezerwacji.SelectedItem.ToString().Trim();

            decimal total = 0;
            List<(string Name, decimal Price, int Qty)> orderedItems = new List<(string, decimal, int)>();

            for (int i = 0; i < menu_dan.Rows.Count; i++)
            {
                string itemName = menu_dan.Rows[i].Cells["dania"].Value?.ToString();
                string priceStr = menu_dan.Rows[i].Cells["cena"].Value?.ToString();
                string qtyStr = menu_dan.Rows[i].Cells["ilosc"].Value?.ToString();

                if (decimal.TryParse(priceStr, out decimal price) &&
                    int.TryParse(qtyStr, out int qty) && qty > 0)
                {
                    total += price * qty;
                    orderedItems.Add((itemName, price, qty));
                }
            }

            string reservationNumber = new Random().Next(100000, 999999).ToString();

            using (var context = new RestaurantContext())
            {
                bool alreadyReserved = context.Reservations.Any(r =>
                r.ReservationDate == date &&
                r.ReservationTime.Trim() == time &&
                r.TableNumber == selectedTable);

                if (alreadyReserved)
                {
                    MessageBox.Show("Ten stolik jest już zarezerwowany na wybraną godzinę. Proszę wybrać inny stolik.");
                    ShowAvailableTables();
                }

                var customer = context.Customers
                    .FirstOrDefault(c => c.Name == name && c.PhoneNumber == phone);
                if (customer == null)
                {
                    customer = new Customer { Name = name, PhoneNumber = phone };
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    AuditLogger.Log("Dodano rezerwację", $"Nr: {reservationNumber}, Klient: {name}, Stolik: {selectedTable}, Data: {date} {time}");
                }

                var reservation = new Projekt_Restauracja.Models.Reservation
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = name,
                    PhoneNumber = phone,
                    ReservationDate = date,
                    ReservationTime = time,
                    TableNumber = selectedTable,
                    TotalAmount = total,
                    ReservationNumber = reservationNumber
                };
                context.Reservations.Add(reservation);
                context.SaveChanges();

                var order = new Projekt_Restauracja.Models.Order
                {
                    ReservationId = reservation.Id,
                    OrderItems = new List<Projekt_Restauracja.Models.OrderItem>(),
                    CreatedAt = DateTime.Now,
                    OrderDate = DateTime.Now,
                    TotalAmount = total
                };

                foreach (var item in orderedItems)
                {
                    var menuItem = context.MenuItems.FirstOrDefault(m => m.Name == item.Name);
                    if (menuItem == null)
                    {
                        MessageBox.Show($"Danie '{item.Name}' nie istnieje w menu! Zamówienia mogą być składane tylko na dania z menu.");
                        return;
                    }
                    var orderItem = new Projekt_Restauracja.Models.OrderItem
                    {
                        MenuItemId = menuItem.MenuItemId,
                        Quantity = item.Qty,
                        UnitPrice = menuItem.Price
                    };
                    order.OrderItems.Add(orderItem);
                }
                order.TotalAmount = order.OrderItems.Sum(oi => oi.UnitPrice * oi.Quantity);
                context.Orders.Add(order);
                context.SaveChanges();

                MessageBox.Show($"Twoja rezerwacja została zapisana. Numer rezerwacji: {reservationNumber}");

                var reservationLib = new RestauracjaLib.Reservation(
                    reservation.CustomerName,
                    reservation.PhoneNumber,
                    reservation.ReservationDate,
                    reservation.ReservationTime,
                    reservation.TableNumber,
                    reservation.TotalAmount,
                    reservation.ReservationNumber
                );
                var form2 = new Formularz2(reservationLib);
                form2.Show();
            }

            ShowAvailableTables();
            btnrezerwacja.Enabled = false;
        }
    }
}
