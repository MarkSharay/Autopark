using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class ElectricalEngine : Engine
    {
        double electricityConsuption { get; set; }
        public ElectricalEngine(double electricityConsumption) : base("Electrical", 0.1)
        {
            this.electricityConsuption = electricityConsumption;
        }
        double GetMaxKilometers(double battarySize)
        {
            return battarySize / electricityConsuption;
        }
    }
}
