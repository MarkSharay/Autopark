using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class GasolineEngine : AbstractCombustionEngine
    {
        public GasolineEngine(double engineCapacity, double fuelConsumptionPer100)
            :base("Gasoline", 1)
        {
            this.engineCapacity = engineCapacity;
            this.fuelConsuptionPer100 = fuelConsumptionPer100; // Not necessary to use 'this' here
        }
    }
}
