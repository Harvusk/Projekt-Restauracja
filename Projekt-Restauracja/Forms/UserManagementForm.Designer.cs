namespace Projekt_Restauracja
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;

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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(540, 370);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewUsers.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 33, 39);
            this.dataGridViewUsers.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            this.dataGridViewUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 37, 44);
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(600, 60);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(160, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Dodaj użytkownika";
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(600, 120);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(160, 40);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edytuj użytkownika";
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(600, 180);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Usuń użytkownika";
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(193, 48, 48);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "UserManagementForm";
            this.Text = "Zarządzanie użytkownikami";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}