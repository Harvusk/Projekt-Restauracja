using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{
    public class SpecialReservation : Reservation
    {
        public string Occasion { get; private set; }

        public SpecialReservation(string name, string phone, DateTime date, string time, int tableNumber, decimal total, string reservationNumber, string occasion)
            : base(name, phone, date, time, tableNumber, total, reservationNumber)
        {
            Occasion = occasion;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" (Okazja: {Occasion})";
        }
    }

}
