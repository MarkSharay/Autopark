using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal static class EngineCreator
    {
        
        public static AbstractEngine CreateEngine(string name, params double[] values)
        {
            switch (name)
            {
                case "Diesel":
                    DieselEngine dieselEngine = new DieselEngine(values[0], values[1]);
                    return dieselEngine;
                case "Gasoline":
                    GasolineEngine gasolineEngine = new GasolineEngine(values[0], values[1]);
                    return gasolineEngine;
                case "Electrical":
                    ElectricalEngine electricalEngine = new ElectricalEngine(values[1]);
                    return electricalEngine;
                default:
                    return null;
            }
        }
    }
}
