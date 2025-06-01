using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{

    public class ReservationManager
    {
        private List<Reservation> reservations = new List<Reservation>();
        private List<Table> tables = new List<Table>();

        public ReservationManager(int tableCount)
        {
            for (int i = 1; i <= tableCount; i++)
                tables.Add(new Table(i));
        }

        public bool IsTableAvailable(int tableNumber, DateTime date, string time)
        {
            return !reservations.Any(r => r.TableNumber == tableNumber && r.Date == date && r.Time == time);
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public List<Table> GetAvailableTables(DateTime date, string time)
        {
            return tables.Where(t => IsTableAvailable(t.Number, date, time)).ToList();
        }
    }

}
