namespace Projekt_Restauracja
{
    partial class Formularz2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formularz2));
            Naglowek_form2 = new Label();
            kolumna_wyswietl_rezerwacje_form2 = new Label();
            kolumna_podziekowanie_form2 = new Label();
            btn_oplac_zamownienie_form2 = new Button();
            btn_usun_rezerwacje_form2 = new Button();
            tabela_wyswietlanie_rezerwacji = new TableLayoutPanel();
            daneosobowe_wyswietlenie_naglowek = new Label();
            stolik_form2_naglowek = new Label();
            Nr_Rezerwacji_form2_naglowek = new Label();
            suma_wyswietlanie_naglowek = new Label();
            tabela_wyswietlanie_rezerwacji.SuspendLayout();
            SuspendLayout();
            // 
            // Naglowek_form2
            // 
            Naglowek_form2.AutoSize = true;
            Naglowek_form2.BackColor = Color.Transparent;
            Naglowek_form2.Font = new Font("Palatino Linotype", 24.2F);
            Naglowek_form2.ForeColor = Color.White;
            Naglowek_form2.Location = new Point(921, 84);
            Naglowek_form2.Name = "Naglowek_form2";
            Naglowek_form2.Size = new Size(486, 45);
            Naglowek_form2.TabIndex = 2;
            Naglowek_form2.Text = "★☆★ Złożone Rezerwacje ★☆★";
            // 
            // kolumna_wyswietl_rezerwacje_form2
            // 
            kolumna_wyswietl_rezerwacje_form2.BackColor = Color.Transparent;
            kolumna_wyswietl_rezerwacje_form2.BorderStyle = BorderStyle.Fixed3D;
            kolumna_wyswietl_rezerwacje_form2.Font = new Font("Palatino Linotype", 12.2F);
            kolumna_wyswietl_rezerwacje_form2.ForeColor = SystemColors.ButtonFace;
            kolumna_wyswietl_rezerwacje_form2.Location = new Point(670, 304);
            kolumna_wyswietl_rezerwacje_form2.Name = "kolumna_wyswietl_rezerwacje_form2";
            kolumna_wyswietl_rezerwacje_form2.Padding = new Padding(15);
            kolumna_wyswietl_rezerwacje_form2.Size = new Size(1135, 389);
            kolumna_wyswietl_rezerwacje_form2.TabIndex = 5;
            kolumna_wyswietl_rezerwacje_form2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kolumna_podziekowanie_form2
            // 
            kolumna_podziekowanie_form2.BackColor = Color.Transparent;
            kolumna_podziekowanie_form2.BorderStyle = BorderStyle.Fixed3D;
            kolumna_podziekowanie_form2.Font = new Font("Palatino Linotype", 18.2F);
            kolumna_podziekowanie_form2.ForeColor = SystemColors.ButtonFace;
            kolumna_podziekowanie_form2.Location = new Point(670, 178);
            kolumna_podziekowanie_form2.Name = "kolumna_podziekowanie_form2";
            kolumna_podziekowanie_form2.Padding = new Padding(15);
            kolumna_podziekowanie_form2.Size = new Size(1135, 126);
            kolumna_podziekowanie_form2.TabIndex = 14;
            kolumna_podziekowanie_form2.Text = "Dziękujemy Państwu za wybór naszej restauracji i życzymy smacznego.";
            kolumna_podziekowanie_form2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_oplac_zamownienie_form2
            // 
            btn_oplac_zamownienie_form2.BackColor = Color.White;
            btn_oplac_zamownienie_form2.ForeColor = Color.Black;
            btn_oplac_zamownienie_form2.Location = new Point(1602, 702);
            btn_oplac_zamownienie_form2.Name = "btn_oplac_zamownienie_form2";
            btn_oplac_zamownienie_form2.Size = new Size(203, 45);
            btn_oplac_zamownienie_form2.TabIndex = 15;
            btn_oplac_zamownienie_form2.Text = "Opłać Rezerwacje";
            btn_oplac_zamownienie_form2.UseVisualStyleBackColor = false;
            // 
            // btn_usun_rezerwacje_form2
            // 
            btn_usun_rezerwacje_form2.BackColor = Color.White;
            btn_usun_rezerwacje_form2.ForeColor = Color.IndianRed;
            btn_usun_rezerwacje_form2.Location = new Point(1351, 702);
            btn_usun_rezerwacje_form2.Name = "btn_usun_rezerwacje_form2";
            btn_usun_rezerwacje_form2.Size = new Size(203, 45);
            btn_usun_rezerwacje_form2.TabIndex = 16;
            btn_usun_rezerwacje_form2.Text = "Anuluj Rezerwacje";
            btn_usun_rezerwacje_form2.UseVisualStyleBackColor = false;
            // 
            // tabela_wyswietlanie_rezerwacji
            // 
            tabela_wyswietlanie_rezerwacji.BackColor = Color.Transparent;
            tabela_wyswietlanie_rezerwacji.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tabela_wyswietlanie_rezerwacji.ColumnCount = 4;
            tabela_wyswietlanie_rezerwacji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tabela_wyswietlanie_rezerwacji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabela_wyswietlanie_rezerwacji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabela_wyswietlanie_rezerwacji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabela_wyswietlanie_rezerwacji.Controls.Add(daneosobowe_wyswietlenie_naglowek, 0, 0);
            tabela_wyswietlanie_rezerwacji.Controls.Add(stolik_form2_naglowek, 1, 0);
            tabela_wyswietlanie_rezerwacji.Controls.Add(Nr_Rezerwacji_form2_naglowek, 3, 0);
            tabela_wyswietlanie_rezerwacji.Controls.Add(suma_wyswietlanie_naglowek, 2, 0);
            tabela_wyswietlanie_rezerwacji.Location = new Point(701, 343);
            tabela_wyswietlanie_rezerwacji.Name = "tabela_wyswietlanie_rezerwacji";
            tabela_wyswietlanie_rezerwacji.RowCount = 2;
            tabela_wyswietlanie_rezerwacji.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tabela_wyswietlanie_rezerwacji.RowStyles.Add(new RowStyle());
            tabela_wyswietlanie_rezerwacji.Size = new Size(1074, 301);
            tabela_wyswietlanie_rezerwacji.TabIndex = 17;
            tabela_wyswietlanie_rezerwacji.Paint += tabela_wyswietlanie_rezerwacji_Paint;
            // 
            // daneosobowe_wyswietlenie_naglowek
            // 
            daneosobowe_wyswietlenie_naglowek.AutoSize = true;
            daneosobowe_wyswietlenie_naglowek.BackColor = Color.White;
            daneosobowe_wyswietlenie_naglowek.Dock = DockStyle.Fill;
            daneosobowe_wyswietlenie_naglowek.Font = new Font("Palatino Linotype", 14F);
            daneosobowe_wyswietlenie_naglowek.ForeColor = Color.Black;
            daneosobowe_wyswietlenie_naglowek.Location = new Point(4, 1);
            daneosobowe_wyswietlenie_naglowek.Name = "daneosobowe_wyswietlenie_naglowek";
            daneosobowe_wyswietlenie_naglowek.Size = new Size(421, 60);
            daneosobowe_wyswietlenie_naglowek.TabIndex = 0;
            daneosobowe_wyswietlenie_naglowek.Text = "Dane Osobowe";
            daneosobowe_wyswietlenie_naglowek.TextAlign = ContentAlignment.MiddleCenter;
            daneosobowe_wyswietlenie_naglowek.Click += daneosobowe_wyswietlenie_naglowek_Click;
            // 
            // stolik_form2_naglowek
            // 
            stolik_form2_naglowek.AutoSize = true;
            stolik_form2_naglowek.BackColor = Color.White;
            stolik_form2_naglowek.Dock = DockStyle.Fill;
            stolik_form2_naglowek.Font = new Font("Palatino Linotype", 14F);
            stolik_form2_naglowek.ForeColor = Color.Black;
            stolik_form2_naglowek.Location = new Point(432, 1);
            stolik_form2_naglowek.Name = "stolik_form2_naglowek";
            stolik_form2_naglowek.Size = new Size(207, 60);
            stolik_form2_naglowek.TabIndex = 1;
            stolik_form2_naglowek.Text = "Stolik";
            stolik_form2_naglowek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Nr_Rezerwacji_form2_naglowek
            // 
            Nr_Rezerwacji_form2_naglowek.AutoSize = true;
            Nr_Rezerwacji_form2_naglowek.BackColor = Color.White;
            Nr_Rezerwacji_form2_naglowek.Dock = DockStyle.Fill;
            Nr_Rezerwacji_form2_naglowek.Font = new Font("Palatino Linotype", 14F);
            Nr_Rezerwacji_form2_naglowek.ForeColor = Color.Black;
            Nr_Rezerwacji_form2_naglowek.Location = new Point(860, 1);
            Nr_Rezerwacji_form2_naglowek.Name = "Nr_Rezerwacji_form2_naglowek";
            Nr_Rezerwacji_form2_naglowek.Size = new Size(210, 60);
            Nr_Rezerwacji_form2_naglowek.TabIndex = 3;
            Nr_Rezerwacji_form2_naglowek.Text = "Numer Rezerwacji";
            Nr_Rezerwacji_form2_naglowek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // suma_wyswietlanie_naglowek
            // 
            suma_wyswietlanie_naglowek.AutoSize = true;
            suma_wyswietlanie_naglowek.BackColor = Color.White;
            suma_wyswietlanie_naglowek.Dock = DockStyle.Fill;
            suma_wyswietlanie_naglowek.Font = new Font("Palatino Linotype", 14F);
            suma_wyswietlanie_naglowek.ForeColor = Color.Black;
            suma_wyswietlanie_naglowek.Location = new Point(646, 1);
            suma_wyswietlanie_naglowek.Name = "suma_wyswietlanie_naglowek";
            suma_wyswietlanie_naglowek.Size = new Size(207, 60);
            suma_wyswietlanie_naglowek.TabIndex = 2;
            suma_wyswietlanie_naglowek.Text = "Kwota";
            suma_wyswietlanie_naglowek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Formularz2
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1253);
            Controls.Add(tabela_wyswietlanie_rezerwacji);
            Controls.Add(btn_usun_rezerwacje_form2);
            Controls.Add(btn_oplac_zamownienie_form2);
            Controls.Add(kolumna_podziekowanie_form2);
            Controls.Add(kolumna_wyswietl_rezerwacje_form2);
            Controls.Add(Naglowek_form2);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Formularz2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Złożone Zamówienia";
            tabela_wyswietlanie_rezerwacji.ResumeLayout(false);
            tabela_wyswietlanie_rezerwacji.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Naglowek_form2;
        private System.Windows.Forms.Label kolumna_wyswietl_rezerwacje_form2;
        private System.Windows.Forms.Label kolumna_podziekowanie_form2;
        private System.Windows.Forms.Button btn_oplac_zamownienie_form2;
        private System.Windows.Forms.Button btn_usun_rezerwacje_form2;
        private System.Windows.Forms.TableLayoutPanel tabela_wyswietlanie_rezerwacji;
        private System.Windows.Forms.Label daneosobowe_wyswietlenie_naglowek;
        private System.Windows.Forms.Label stolik_form2_naglowek;
        private System.Windows.Forms.Label suma_wyswietlanie_naglowek;
        private System.Windows.Forms.Label Nr_Rezerwacji_form2_naglowek;
    }
}