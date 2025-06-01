using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{
    public interface IReservation
    {
        bool Validate();
        string GetSummary();
    }
}
