using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class AbstractCombustionEngine : AbstractEngine
    {
        protected double engineCapacity { get; set; } // CamelCase
        protected double fuelConsuptionPer100 { get; set; } // CamelCase

        public override double GetMaxKilometers(double fuelTankCapacity) // Method should be placed after constructor
        {
            return fuelTankCapacity*100/fuelConsuptionPer100;
        }

        public AbstractCombustionEngine(string typeName, double taxCoefficient) 
            : base(typeName, taxCoefficient) { }
        

    }
}
