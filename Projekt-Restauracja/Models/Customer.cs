using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Restauracja.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

    }
}
