using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{
    public class Table
    {
        public int Number { get; }
        public bool IsAvailable { get; set; }

        public Table(int number)
        {
            Number = number;
            IsAvailable = true;
        }
    }

}
