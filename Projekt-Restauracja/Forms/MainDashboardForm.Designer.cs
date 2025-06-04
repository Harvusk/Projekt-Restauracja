namespace Projekt_Restauracja
{
    partial class Formularz
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formularz));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Naglowek = new Label();
            Opis_Restauracja = new Label();
            kolumna_lewa1 = new Label();
            imienazwisko = new TextBox();
            kolumna_lewa2 = new Label();
            kolumna_lewa3 = new Label();
            numer_telefonu = new TextBox();
            kolumna_prawa1 = new Label();
            kolumna_prawa2 = new Label();
            kolumna_prawa3 = new Label();
            kolumna_lewa4 = new Label();
            kolumna_lewa5 = new Label();
            kolumna_prawa4 = new Label();
            menu_dan = new DataGridView();
            dania = new DataGridViewTextBoxColumn();
            cena = new DataGridViewTextBoxColumn();
            ilosc = new DataGridViewTextBoxColumn();
            btnstolik1 = new Button();
            btnstolik2 = new Button();
            btnstolik3 = new Button();
            btnstolik4 = new Button();
            btnstolik5 = new Button();
            btnstolik6 = new Button();
            suma_zamowienia = new Label();
            btnrezerwacja = new Button();
            data_rezerwacji = new DateTimePicker();
            kolumna_prawa5 = new Label();
            godzina_rezerwacji = new ComboBox();
            btnStaffLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)menu_dan).BeginInit();
            SuspendLayout();
            // 
            // Naglowek
            // 
            Naglowek.AutoSize = true;
            Naglowek.BackColor = Color.Transparent;
            Naglowek.Font = new Font("Palatino Linotype", 20.2F);
            Naglowek.ForeColor = Color.White;
            Naglowek.Location = new Point(883, 41);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(575, 36);
            Naglowek.TabIndex = 1;
            Naglowek.Text = "★☆★ Witamy w „Margherita La Vrange” ★☆★";
            // 
            // Opis_Restauracja
            // 
            Opis_Restauracja.BackColor = Color.Transparent;
            Opis_Restauracja.BorderStyle = BorderStyle.Fixed3D;
            Opis_Restauracja.Font = new Font("Palatino Linotype", 12.2F);
            Opis_Restauracja.ForeColor = SystemColors.ButtonFace;
            Opis_Restauracja.Location = new Point(687, 124);
            Opis_Restauracja.Name = "Opis_Restauracja";
            Opis_Restauracja.Padding = new Padding(15);
            Opis_Restauracja.Size = new Size(900, 200);
            Opis_Restauracja.TabIndex = 2;
            Opis_Restauracja.Text = resources.GetString("Opis_Restauracja.Text");
            // 
            // kolumna_lewa1
            // 
            kolumna_lewa1.BackColor = Color.Transparent;
            kolumna_lewa1.BorderStyle = BorderStyle.Fixed3D;
            kolumna_lewa1.Font = new Font("Palatino Linotype", 15.2F);
            kolumna_lewa1.ForeColor = SystemColors.ButtonFace;
            kolumna_lewa1.Location = new Point(687, 334);
            kolumna_lewa1.Name = "kolumna_lewa1";
            kolumna_lewa1.Padding = new Padding(5);
            kolumna_lewa1.Size = new Size(420, 75);
            kolumna_lewa1.TabIndex = 3;
            kolumna_lewa1.Text = "⇲ Podaj swoje dane";
            kolumna_lewa1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imienazwisko
            // 
            imienazwisko.Location = new Point(719, 528);
            imienazwisko.Name = "imienazwisko";
            imienazwisko.PlaceholderText = "1.Podaj - Imie i Nazwisko";
            imienazwisko.Size = new Size(360, 26);
            imienazwisko.TabIndex = 4;
            // 
            // kolumna_lewa2
            // 
            kolumna_lewa2.BackColor = Color.Transparent;
            kolumna_lewa2.BorderStyle = BorderStyle.Fixed3D;
            kolumna_lewa2.Location = new Point(687, 409);
            kolumna_lewa2.Name = "kolumna_lewa2";
            kolumna_lewa2.Padding = new Padding(10);
            kolumna_lewa2.Size = new Size(420, 70);
            kolumna_lewa2.TabIndex = 5;
            kolumna_lewa2.Text = "Prosimy o wypełnienie wszystkich pól poniżej, \r\nby móc poprawnie wybrać stolik:";
            kolumna_lewa2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kolumna_lewa3
            // 
            kolumna_lewa3.BackColor = Color.Transparent;
            kolumna_lewa3.BorderStyle = BorderStyle.Fixed3D;
            kolumna_lewa3.Location = new Point(687, 479);
            kolumna_lewa3.Name = "kolumna_lewa3";
            kolumna_lewa3.Size = new Size(420, 300);
            kolumna_lewa3.TabIndex = 6;
            // 
            // numer_telefonu
            // 
            numer_telefonu.Location = new Point(719, 587);
            numer_telefonu.Name = "numer_telefonu";
            numer_telefonu.PlaceholderText = "2.Podaj - Numer Telefonu";
            numer_telefonu.Size = new Size(360, 26);
            numer_telefonu.TabIndex = 7;
            // 
            // kolumna_prawa1
            // 
            kolumna_prawa1.BackColor = Color.Transparent;
            kolumna_prawa1.BorderStyle = BorderStyle.Fixed3D;
            kolumna_prawa1.Font = new Font("Palatino Linotype", 15.2F);
            kolumna_prawa1.Location = new Point(1107, 334);
            kolumna_prawa1.Name = "kolumna_prawa1";
            kolumna_prawa1.Size = new Size(680, 75);
            kolumna_prawa1.TabIndex = 10;
            kolumna_prawa1.Text = "🍽️ ⇹ Menu ⇹ 🍽️";
            kolumna_prawa1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kolumna_prawa2
            // 
            kolumna_prawa2.BackColor = Color.Transparent;
            kolumna_prawa2.BorderStyle = BorderStyle.Fixed3D;
            kolumna_prawa2.Location = new Point(1107, 409);
            kolumna_prawa2.Name = "kolumna_prawa2";
            kolumna_prawa2.Padding = new Padding(10);
            kolumna_prawa2.Size = new Size(680, 70);
            kolumna_prawa2.TabIndex = 11;
            kolumna_prawa2.Text = "W naszej restauracji dostępnych jest wiele różnych dań oraz napojów, \r\nponiżej znajdziecie Państwo ich listę:";
            kolumna_prawa2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kolumna_prawa3
            // 
            kolumna_prawa3.BackColor = Color.Transparent;
            kolumna_prawa3.BorderStyle = BorderStyle.Fixed3D;
            kolumna_prawa3.Location = new Point(1107, 479);
            kolumna_prawa3.Name = "kolumna_prawa3";
            kolumna_prawa3.Size = new Size(680, 570);
            kolumna_prawa3.TabIndex = 12;
            // 
            // kolumna_lewa4
            // 
            kolumna_lewa4.BackColor = Color.Transparent;
            kolumna_lewa4.BorderStyle = BorderStyle.Fixed3D;
            kolumna_lewa4.Location = new Point(687, 779);
            kolumna_lewa4.Name = "kolumna_lewa4";
            kolumna_lewa4.Size = new Size(420, 70);
            kolumna_lewa4.TabIndex = 13;
            kolumna_lewa4.Text = "Proszę wybrać jeden z dostepnych stolików poniżej:";
            kolumna_lewa4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kolumna_lewa5
            // 
            kolumna_lewa5.BackColor = Color.Transparent;
            kolumna_lewa5.BorderStyle = BorderStyle.Fixed3D;
            kolumna_lewa5.Location = new Point(687, 849);
            kolumna_lewa5.Name = "kolumna_lewa5";
            kolumna_lewa5.Size = new Size(420, 337);
            kolumna_lewa5.TabIndex = 14;
            // 
            // kolumna_prawa4
            // 
            kolumna_prawa4.BackColor = Color.Transparent;
            kolumna_prawa4.BorderStyle = BorderStyle.Fixed3D;
            kolumna_prawa4.Font = new Font("Palatino Linotype", 18.2F);
            kolumna_prawa4.Location = new Point(1107, 1049);
            kolumna_prawa4.Name = "kolumna_prawa4";
            kolumna_prawa4.Size = new Size(680, 67);
            kolumna_prawa4.TabIndex = 15;
            kolumna_prawa4.Text = "                                           ↼↼↼↫↬⇀⇀⇀";
            kolumna_prawa4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menu_dan
            // 
            menu_dan.AllowUserToAddRows = false;
            menu_dan.AllowUserToDeleteRows = false;
            menu_dan.AllowUserToResizeColumns = false;
            menu_dan.AllowUserToResizeRows = false;
            menu_dan.BackgroundColor = SystemColors.Desktop;
            menu_dan.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            menu_dan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            menu_dan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menu_dan.Columns.AddRange(new DataGridViewColumn[] { dania, cena, ilosc });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            menu_dan.DefaultCellStyle = dataGridViewCellStyle4;
            menu_dan.EnableHeadersVisualStyles = false;
            menu_dan.Location = new Point(1138, 504);
            menu_dan.MultiSelect = false;
            menu_dan.Name = "menu_dan";
            menu_dan.RowHeadersVisible = false;
            menu_dan.RowHeadersWidth = 60;
            menu_dan.Size = new Size(616, 520);
            menu_dan.TabIndex = 16;
            menu_dan.CellBeginEdit += menu_dan_CellBeginEdit;
            menu_dan.CellClick += menu_dan_grid_CellClick;
            menu_dan.CellValueChanged += menu_dan_CellValueChanged;
            // 
            // dania
            // 
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dania.DefaultCellStyle = dataGridViewCellStyle2;
            dania.HeaderText = "Nazwa Dania";
            dania.MinimumWidth = 6;
            dania.Name = "dania";
            dania.ReadOnly = true;
            dania.SortMode = DataGridViewColumnSortMode.NotSortable;
            dania.Width = 330;
            // 
            // cena
            // 
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            cena.DefaultCellStyle = dataGridViewCellStyle3;
            cena.HeaderText = "Cena (zł)";
            cena.MinimumWidth = 6;
            cena.Name = "cena";
            cena.ReadOnly = true;
            cena.SortMode = DataGridViewColumnSortMode.NotSortable;
            cena.Width = 110;
            // 
            // ilosc
            // 
            ilosc.HeaderText = "Ilość (Wpisać) ";
            ilosc.MinimumWidth = 6;
            ilosc.Name = "ilosc";
            ilosc.SortMode = DataGridViewColumnSortMode.NotSortable;
            ilosc.Width = 150;
            // 
            // btnstolik1
            // 
            btnstolik1.BackColor = Color.Black;
            btnstolik1.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik1.Location = new Point(719, 867);
            btnstolik1.Name = "btnstolik1";
            btnstolik1.Size = new Size(160, 80);
            btnstolik1.TabIndex = 17;
            btnstolik1.Text = "Stolik nr 1";
            btnstolik1.UseVisualStyleBackColor = false;
            // 
            // btnstolik2
            // 
            btnstolik2.BackColor = Color.Black;
            btnstolik2.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik2.Location = new Point(919, 867);
            btnstolik2.Name = "btnstolik2";
            btnstolik2.Size = new Size(160, 80);
            btnstolik2.TabIndex = 18;
            btnstolik2.Text = "Stolik nr 2";
            btnstolik2.UseVisualStyleBackColor = false;
            // 
            // btnstolik3
            // 
            btnstolik3.BackColor = Color.Black;
            btnstolik3.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik3.Location = new Point(719, 969);
            btnstolik3.Name = "btnstolik3";
            btnstolik3.Size = new Size(160, 80);
            btnstolik3.TabIndex = 19;
            btnstolik3.Text = "Stolik nr 3";
            btnstolik3.UseVisualStyleBackColor = false;
            // 
            // btnstolik4
            // 
            btnstolik4.BackColor = Color.Black;
            btnstolik4.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik4.Location = new Point(919, 969);
            btnstolik4.Name = "btnstolik4";
            btnstolik4.Size = new Size(160, 80);
            btnstolik4.TabIndex = 20;
            btnstolik4.Text = "Stolik nr 4";
            btnstolik4.UseVisualStyleBackColor = false;
            // 
            // btnstolik5
            // 
            btnstolik5.BackColor = Color.Black;
            btnstolik5.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik5.Location = new Point(719, 1073);
            btnstolik5.Name = "btnstolik5";
            btnstolik5.Size = new Size(160, 80);
            btnstolik5.TabIndex = 21;
            btnstolik5.Text = "Stolik nr 5";
            btnstolik5.UseVisualStyleBackColor = false;
            // 
            // btnstolik6
            // 
            btnstolik6.BackColor = Color.Black;
            btnstolik6.Font = new Font("Palatino Linotype", 11.2F);
            btnstolik6.Location = new Point(919, 1073);
            btnstolik6.Name = "btnstolik6";
            btnstolik6.Size = new Size(160, 80);
            btnstolik6.TabIndex = 22;
            btnstolik6.Text = "Stolik nr 6";
            btnstolik6.UseVisualStyleBackColor = false;
            // 
            // suma_zamowienia
            // 
            suma_zamowienia.BackColor = Color.White;
            suma_zamowienia.Font = new Font("Palatino Linotype", 13.2F);
            suma_zamowienia.ForeColor = Color.Black;
            suma_zamowienia.Location = new Point(1138, 1068);
            suma_zamowienia.Name = "suma_zamowienia";
            suma_zamowienia.Size = new Size(165, 35);
            suma_zamowienia.TabIndex = 25;
            suma_zamowienia.Text = "Suma: 0,00 zł";
            suma_zamowienia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnrezerwacja
            // 
            btnrezerwacja.BackColor = Color.Snow;
            btnrezerwacja.Font = new Font("Palatino Linotype", 11.2F);
            btnrezerwacja.ForeColor = Color.Black;
            btnrezerwacja.Location = new Point(1564, 1067);
            btnrezerwacja.Name = "btnrezerwacja";
            btnrezerwacja.Size = new Size(165, 36);
            btnrezerwacja.TabIndex = 26;
            btnrezerwacja.Text = "REZERWACJA";
            btnrezerwacja.UseVisualStyleBackColor = false;
            // 
            // data_rezerwacji
            // 
            data_rezerwacji.Format = DateTimePickerFormat.Short;
            data_rezerwacji.Location = new Point(719, 641);
            data_rezerwacji.MaxDate = new DateTime(2025, 7, 31, 0, 0, 0, 0);
            data_rezerwacji.MinDate = new DateTime(2025, 5, 30, 0, 0, 0, 0);
            data_rezerwacji.Name = "data_rezerwacji";
            data_rezerwacji.Size = new Size(360, 26);
            data_rezerwacji.TabIndex = 28;
            data_rezerwacji.Value = new DateTime(2025, 5, 30, 0, 0, 0, 0);
            // 
            // kolumna_prawa5
            // 
            kolumna_prawa5.BackColor = Color.Transparent;
            kolumna_prawa5.BorderStyle = BorderStyle.Fixed3D;
            kolumna_prawa5.Location = new Point(1107, 1116);
            kolumna_prawa5.Name = "kolumna_prawa5";
            kolumna_prawa5.Padding = new Padding(10);
            kolumna_prawa5.Size = new Size(680, 70);
            kolumna_prawa5.TabIndex = 30;
            kolumna_prawa5.Text = "Prosimy Państwa o przemyślane rezerwacje. W przypadku rezygnacji \r\nprosimy o kontakt telefoniczny na numer -> 111-222-333";
            kolumna_prawa5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // godzina_rezerwacji
            // 
            godzina_rezerwacji.Location = new Point(719, 703);
            godzina_rezerwacji.Name = "godzina_rezerwacji";
            godzina_rezerwacji.Size = new Size(360, 27);
            godzina_rezerwacji.TabIndex = 0;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.BackColor = Color.Black;
            btnStaffLogin.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnStaffLogin.ForeColor = SystemColors.ButtonHighlight;
            btnStaffLogin.Location = new Point(1686, 12);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new Size(180, 35);
            btnStaffLogin.TabIndex = 100;
            btnStaffLogin.Text = "Zaloguj jako personel";
            btnStaffLogin.UseVisualStyleBackColor = false;
            // 
            // Formularz
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1646, 1006);
            Controls.Add(godzina_rezerwacji);
            Controls.Add(kolumna_prawa5);
            Controls.Add(data_rezerwacji);
            Controls.Add(btnrezerwacja);
            Controls.Add(suma_zamowienia);
            Controls.Add(btnstolik6);
            Controls.Add(btnstolik5);
            Controls.Add(btnstolik4);
            Controls.Add(btnstolik3);
            Controls.Add(btnstolik2);
            Controls.Add(btnstolik1);
            Controls.Add(btnStaffLogin);
            Controls.Add(menu_dan);
            Controls.Add(kolumna_prawa4);
            Controls.Add(kolumna_lewa5);
            Controls.Add(kolumna_lewa4);
            Controls.Add(kolumna_prawa3);
            Controls.Add(kolumna_prawa2);
            Controls.Add(kolumna_prawa1);
            Controls.Add(numer_telefonu);
            Controls.Add(imienazwisko);
            Controls.Add(kolumna_lewa3);
            Controls.Add(kolumna_lewa2);
            Controls.Add(kolumna_lewa1);
            Controls.Add(Opis_Restauracja);
            Controls.Add(Naglowek);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Formularz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularz Rezerwacji Stolika";
            Load += Formularz_Load;
            ((System.ComponentModel.ISupportInitialize)menu_dan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Naglowek;
        private System.Windows.Forms.Label Opis_Restauracja;
        private System.Windows.Forms.Label kolumna_lewa1;
        private System.Windows.Forms.TextBox imienazwisko;
        private System.Windows.Forms.Label kolumna_lewa2;
        private System.Windows.Forms.Label kolumna_lewa3;
        private System.Windows.Forms.TextBox numer_telefonu;
        private System.Windows.Forms.Label kolumna_prawa1;
        private System.Windows.Forms.Label kolumna_prawa2;
        private System.Windows.Forms.Label kolumna_prawa3;
        private System.Windows.Forms.Label kolumna_lewa4;
        private System.Windows.Forms.Label kolumna_lewa5;
        private System.Windows.Forms.Label kolumna_prawa4;
        private System.Windows.Forms.DataGridView menu_dan;
        private System.Windows.Forms.Button btnstolik1;
        private System.Windows.Forms.Button btnstolik2;
        private System.Windows.Forms.Button btnstolik3;
        private System.Windows.Forms.Button btnstolik4;
        private System.Windows.Forms.Button btnstolik5;
        private System.Windows.Forms.Button btnstolik6;
        private System.Windows.Forms.Label suma_zamowienia;
        private System.Windows.Forms.Button btnrezerwacja;
        private System.Windows.Forms.DateTimePicker data_rezerwacji;
        private System.Windows.Forms.Label kolumna_prawa5;
        private System.Windows.Forms.ComboBox godzina_rezerwacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn dania;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.Button btnStaffLogin;
    }
}
