using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Vehicle:IComparable
    {
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Weight { get; set; }
        public int Year { get; set; }
        public Colors Color { get; set; }
        public double Volume { get; set; }

        public double GetCalcTaxPerMonth()
        {
            return (this.Weight * 0.00013) + (Type.TaxCoefficient * 30) + 5;
        }
        int IComparable.CompareTo(Object v)
        {
            Vehicle vehicle = (Vehicle)v;

            if(vehicle != null)
            {
                if(this.GetCalcTaxPerMonth() < vehicle.GetCalcTaxPerMonth())
                {
                    return -1;
                }else if(this.GetCalcTaxPerMonth() > vehicle.GetCalcTaxPerMonth())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Parameter must to be Vehicle type");
            }
        }

    }
}
