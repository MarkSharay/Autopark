using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Engine
    {
        string Name { get; set; }
        double taxCoefficient { get; set; }

        public Engine(string name, double taxCoefficient)
        {
            Name = name;
            this.taxCoefficient = taxCoefficient;
        }
    }
}
