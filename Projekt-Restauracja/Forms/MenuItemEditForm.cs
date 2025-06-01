using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projekt_Restauracja.Forms
{
    public partial class MenuItemEditForm : Form
    {
        public string ItemName
        {
            get => txtName.Text.Trim();
            set => txtName.Text = value;
        }
        public decimal ItemPrice
        {
            get => decimal.TryParse(txtPrice.Text, out var val) ? val : 0;
            set => txtPrice.Text = value.ToString("0.00");
        }
        public string ItemCategory
        {
            get => txtCategory.Text.Trim();
            set => txtCategory.Text = value;
        }

        public MenuItemEditForm()
        {
            InitializeComponent();
        }

        public MenuItemEditForm(string name, decimal price, string category) : this()
        {
            ItemName = name;
            ItemPrice = price;
            ItemCategory = category;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemName) || string.IsNullOrWhiteSpace(ItemCategory))
            {
                MessageBox.Show("Podaj nazwę i kategorię.");
                return;
            }
            if (ItemPrice <= 0)
            {
                MessageBox.Show("Podaj poprawną cenę.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}