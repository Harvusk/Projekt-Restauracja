namespace Projekt_Restauracja.Forms
{
    partial class MenuItemEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // MenuItemEditForm
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.BackColor = System.Drawing.Color.FromArgb(25, 27, 32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytuj Pozycję Menu";

            // lblName
            this.lblName.Text = "Nazwa dania:";
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Size = new System.Drawing.Size(180, 25);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblPrice
            this.lblPrice.Text = "Cena (zł):";
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(30, 70);
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(150, 70);
            this.txtPrice.Size = new System.Drawing.Size(180, 25);
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblCategory
            this.lblCategory.Text = "Kategoria:";
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(30, 110);
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtCategory
            this.txtCategory.Location = new System.Drawing.Point(150, 110);
            this.txtCategory.Size = new System.Drawing.Size(180, 25);
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnOK
            this.btnOK.Text = "OK";
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(0, 158, 96);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(60, 160);
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(193, 48, 48);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(200, 160);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Controls
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
