using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{
    public class Reservation : IReservation
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public DateTime Date { get; private set; }
        public string Time { get; private set; }
        public int TableNumber { get; private set; }
        public decimal Total { get; set; }
        public string ReservationNumber { get; set; }

        public Reservation(string name, string phone, DateTime date, string time, int tableNumber, decimal total, string reservationNumber)
        {
            Name = name;
            Phone = phone;
            Date = date;
            Time = time;
            TableNumber = tableNumber;
            Total = total;
            ReservationNumber = reservationNumber;
        }

        public virtual bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Name)
                && Phone.All(char.IsDigit) && Phone.Length == 9;
        }

        public virtual string GetSummary()
        {
            return $"{Name}, tel: {Phone}, {Date.ToShortDateString()} {Time}, Stolik: {TableNumber}, Suma: {Total}zł, Nr: {ReservationNumber}";
        }
    }

}
