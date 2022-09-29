using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public abstract class AbstractEngine
    {
        string Name { get; set; }
        double taxCoefficient { get; set; }

        public AbstractEngine(string name, double taxCoefficient)
        {
            Name = name;
            this.taxCoefficient = taxCoefficient;
        }
        public abstract double GetMaxKilometers(double fuelTank);
    }
}
