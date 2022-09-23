using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class CombustionEngine : Engine
    {
        protected double engineCapacity { get; set; }
        protected double fuelConsuptionPer100 { get; set; }

        public double GetMaxKilometers(double fuelTankCapacity)
        {
            return fuelTankCapacity*100/fuelConsuptionPer100;
        }

        public CombustionEngine(string typeName, double taxCoefficient) 
            : base(typeName, taxCoefficient) { }
        

    }
}
