using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class ElectricalEngine : AbstractEngine
    {
        double electricityConsuption { get; set; } // CamelCase
        public ElectricalEngine(double electricityConsumption) : base("Electrical", 0.1)
        {
            this.electricityConsuption = electricityConsumption; // Not necessary to use 'this' here
        }
        public override double GetMaxKilometers(double battarySize)
        {
            return battarySize / electricityConsuption;
        }
    }
}
