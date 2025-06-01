namespace Projekt_Restauracja.Forms
{
    partial class MenuManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // --- HEADER PANEL ---
            headerPanel = new System.Windows.Forms.Panel();
            headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 54;

            lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Zarządzanie Menu";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblHeader.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);

            headerPanel.Controls.Add(lblHeader);

            // --- DATA GRID VIEW ---
            dataGridViewMenu = new System.Windows.Forms.DataGridView();
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.Location = new System.Drawing.Point(12, 80);
            dataGridViewMenu.Size = new System.Drawing.Size(876, 450);
            dataGridViewMenu.BackgroundColor = System.Drawing.Color.FromArgb(25, 27, 32);
            dataGridViewMenu.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dataGridViewMenu.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            dataGridViewMenu.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewMenu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            dataGridViewMenu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 37, 44);
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewMenu.EnableHeadersVisualStyles = false;
            dataGridViewMenu.RowHeadersVisible = false;
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AllowUserToOrderColumns = true;
            dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenu.MultiSelect = false;
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // --- BUTTONS ---
            btnAdd = new System.Windows.Forms.Button();
            btnAdd.Text = "Dodaj";
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnAdd.Location = new System.Drawing.Point(12, 20);
            btnAdd.Size = new System.Drawing.Size(150, 45);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;

            btnEdit = new System.Windows.Forms.Button();
            btnEdit.Text = "Edytuj";
            btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnEdit.Location = new System.Drawing.Point(168, 20);
            btnEdit.Size = new System.Drawing.Size(150, 45);
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;

            btnDelete = new System.Windows.Forms.Button();
            btnDelete.Text = "Usuń";
            btnDelete.BackColor = System.Drawing.Color.FromArgb(193, 48, 48);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnDelete.Location = new System.Drawing.Point(324, 20);
            btnDelete.Size = new System.Drawing.Size(150, 45);
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;

            // --- FORM PROPERTIES ---
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dataGridViewMenu);
            this.Controls.Add(headerPanel);
            this.Text = "Zarządzanie Menu";
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.ResumeLayout(false);
        }
    }
}