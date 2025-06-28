using Microsoft.EntityFrameworkCore;
using Projekt_Restauracja.Models;
using System.Diagnostics;


namespace Projekt_Restauracja.Models
{

    public static class AuditLogger
    {

        public static void Log(string action, string details)
        {
            try
            {
                using (var context = new RestaurantContext())
                {
                    var log = new AuditLog
                    {
                        Timestamp = DateTime.Now,
                        Username = Session.CurrentUser?.Username ?? "Unknown",
                        Action = action,
                        Details = details
                    };
                    context.AuditLogs.Add(log);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine($"Update failed: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Auditlog error:{ex.Message}");
            }
        }
    }
}
