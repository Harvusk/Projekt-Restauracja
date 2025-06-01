using System;

namespace Projekt_Restauracja.Models
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string Details { get; set; }
    }
}