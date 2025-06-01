using System;
using System.Windows.Forms;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja
{
    public partial class ReservationEditForm : Form
    {
        public int SelectedTable => (int)comboTable.SelectedItem;
        public string SelectedTime => comboTime.SelectedItem.ToString();

        public ReservationEditForm(Reservation reservation)
        {
            InitializeComponent();

            comboTable.Items.Clear();
            for (int i = 1; i <= 6; i++)
                comboTable.Items.Add(i);

            comboTime.Items.Clear();
            comboTime.Items.AddRange(new object[] {
                "12:00", "12:45", "13:30", "14:15", "15:00",
                "15:45", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15", "21:00"
            });

            comboTable.SelectedItem = reservation.TableNumber;
            comboTime.SelectedItem = reservation.ReservationTime.Trim();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboTable.SelectedItem == null || comboTime.SelectedItem == null)
            {
                MessageBox.Show("Wybierz stolik i godzinę.");
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
