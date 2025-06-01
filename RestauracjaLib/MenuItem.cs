using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauracjaLib
{
    public class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Category { get; }
        public int Quantity { get; set; }

        public MenuItem(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
            Quantity = 0;
        }
    }

}
