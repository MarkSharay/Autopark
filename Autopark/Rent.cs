using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Rent
    {
        public DateTime date { get; set; } // CamelCase

        public double Cost { get; private set; }

        public Rent() { }
        public Rent(DateTime date, double cost)
        {
            this.date = date;
            Cost = cost;
        }
    }
}
