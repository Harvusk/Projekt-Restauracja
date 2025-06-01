using System;
using System.Linq;
using System.Windows.Forms;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Forms
{
    public partial class MenuManagementForm : Form
    {
        public MenuManagementForm()
        {
            InitializeComponent();
            LoadMenuItems();

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void LoadMenuItems()
        {
            using (var context = new RestaurantContext())
            {
                dataGridViewMenu.DataSource = context.MenuItems
                    .Select(m => new
                    {
                        m.MenuItemId,
                        m.Name,
                        m.Price,
                        m.Category
                    })
                    .OrderBy(m => m.Category)
                    .ThenBy(m => m.Name)
                    .ToList();
            }
            dataGridViewMenu.ClearSelection();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new MenuItemEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new RestaurantContext())
                {
                    var menuItem = new MenuItem
                    {
                        Name = form.ItemName,
                        Price = form.ItemPrice,
                        Category = form.ItemCategory
                    };
                    context.MenuItems.Add(menuItem);
                    context.SaveChanges();
                    AuditLogger.Log("Zmieniono menu", $"Danie: {menuItem.Name}, Operacja: dodano");
                }
                LoadMenuItems();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz pozycję do edycji.");
                return;
            }

            int id = (int)dataGridViewMenu.SelectedRows[0].Cells["MenuItemId"].Value;
            using (var context = new RestaurantContext())
            {
                var menuItem = context.MenuItems.FirstOrDefault(m => m.MenuItemId == id);
                if (menuItem == null) return;

                var form = new MenuItemEditForm(menuItem.Name, menuItem.Price, menuItem.Category);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    menuItem.Name = form.ItemName;
                    menuItem.Price = form.ItemPrice;
                    menuItem.Category = form.ItemCategory;
                    context.SaveChanges();
                    AuditLogger.Log("Zmieniono menu", $"Danie: {menuItem.Name}, Operacja: edytowano");
                    LoadMenuItems();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz pozycję do usunięcia.");
                return;
            }
            int id = (int)dataGridViewMenu.SelectedRows[0].Cells["MenuItemId"].Value;
            var confirm = MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję z menu?", "Potwierdź", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (var context = new RestaurantContext())
            {
                var menuItem = context.MenuItems.FirstOrDefault(m => m.MenuItemId == id);
                if (menuItem != null)
                {
                    context.MenuItems.Remove(menuItem);
                    context.SaveChanges();
                    AuditLogger.Log("Zmieniono menu", $"Danie: {menuItem.Name}, Operacja: usunięto");
                }
            }
            LoadMenuItems();
        }
    }
}