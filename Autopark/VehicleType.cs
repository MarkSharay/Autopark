using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class VehicleType
    {
        public int Id { get; private set; }
        public string TypeName { get; private set; }
        public double TaxCoefficient { get; private set; }

        public VehicleType()
        {
            TypeName = string.Empty;
        }
        public VehicleType(int id,string typeName, double taxCoefficient = 1)
        {
            Id = id;
            TypeName = typeName;
            TaxCoefficient = taxCoefficient;
        }
        public VehicleType(string typeName)
        {
            TypeName=typeName;
        }
        public VehicleType(double taxCoefficient)
        {
            TypeName = string.Empty;
            TaxCoefficient = taxCoefficient;
        }

        public void Display()
        {
            Console.WriteLine($" TypeName: {TypeName}");
            Console.WriteLine($" TaxCoefficient: {TaxCoefficient}");
        }
        public override string ToString()
        {
            return $"{Id};{TypeName};{TaxCoefficient}";
        }
    }
}
