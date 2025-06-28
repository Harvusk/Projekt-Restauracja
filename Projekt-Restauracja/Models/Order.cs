using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Restauracja.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
