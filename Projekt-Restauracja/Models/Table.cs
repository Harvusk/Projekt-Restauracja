using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Restauracja.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        [Required]
        [Range(1, 6, ErrorMessage = "Table number must be between 1 and 6.")]
        public int Number { get; set; }

        [Required]
        public int IsAvailable { get; set; } = 1;

        public ICollection<Reservation> Reservations { get; set; }

    }
}
