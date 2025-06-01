using System;
using System.Linq;
using System.Windows.Forms;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Forms
{
    public partial class AuditLogViewerForm : Form
    {
        public AuditLogViewerForm()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void btnViewAuditLog_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            using (var context = new RestaurantContext())
            {
                var logs = context.AuditLogs
                    .OrderByDescending(log => log.Timestamp)
                    .Take(200)
                    .ToList();

                dataGridViewLogs.DataSource = logs;
            }
        }
    }
}