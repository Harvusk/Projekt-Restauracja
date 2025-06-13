using System;
using System.Windows.Forms;
using RestauracjaLib;

namespace Projekt_Restauracja
{
    public partial class Formularz2 : Form
    {
        private Reservation reservation;

        public Formularz2(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            ShowReservation();
            btn_usun_rezerwacje_form2.Click += btn_usun_rezerwacje_form2_Click;
            btn_oplac_zamownienie_form2.Click += btn_oplac_zamownienie_form2_Click;
        }

        public Formularz2()
        {
            InitializeComponent();
        }

        private void ShowReservation()
        {
            for (int i = tabela_wyswietlanie_rezerwacji.Controls.Count - 1; i >= 0; i--)
            {
                var ctrl = tabela_wyswietlanie_rezerwacji.Controls[i];
                if (tabela_wyswietlanie_rezerwacji.GetRow(ctrl) > 0)
                {
                    tabela_wyswietlanie_rezerwacji.Controls.Remove(ctrl);
                }
            }

            var font1 = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            var font2 = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);

            string daneOsobowe = $"{reservation.Name}\nTel: {reservation.Phone}\n{reservation.Date:dd.MM.yyyy} {reservation.Time}";
            tabela_wyswietlanie_rezerwacji.Controls.Add(new Label()
            {
                Text = daneOsobowe,
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = font1
            }, 0, 1);

            tabela_wyswietlanie_rezerwacji.Controls.Add(new Label()
            {
                Text = reservation.TableNumber.ToString(),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = font2
            }, 1, 1);

            tabela_wyswietlanie_rezerwacji.Controls.Add(new Label()
            {
                Text = $"{reservation.Total:0.00} zł",
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = font2
            }, 2, 1);

            tabela_wyswietlanie_rezerwacji.Controls.Add(new Label()
            {
                Text = reservation.ReservationNumber,
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = font2
            }, 3, 1);
        }

        private void btn_usun_rezerwacje_form2_Click(object sender, EventArgs e)
        {
            for (int i = tabela_wyswietlanie_rezerwacji.Controls.Count - 1; i >= 0; i--)
            {
                var ctrl = tabela_wyswietlanie_rezerwacji.Controls[i];
                if (tabela_wyswietlanie_rezerwacji.GetRow(ctrl) > 0)
                {
                    tabela_wyswietlanie_rezerwacji.Controls.Remove(ctrl);
                }
            }
        }

        private void btn_oplac_zamownienie_form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
