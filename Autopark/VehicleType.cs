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
            TypeName = string.Empty; // No need to initialize anything in default constructor
        }
        public VehicleType(int id,string typeName, double taxCoefficient = 1) // Why taxCoefficient is optional param?
        {
            Id = id;
            TypeName = typeName;
            TaxCoefficient = taxCoefficient;
        }
        public VehicleType(string typeName) // This constructor is optional
        {
            TypeName=typeName;
        }
        public VehicleType(double taxCoefficient) // This constructor is optional
        {
            TypeName = string.Empty;
            TaxCoefficient = taxCoefficient;
        }

        public void Display()
        {
            Console.WriteLine($" TypeName: {TypeName}");
            Console.WriteLine($" TaxCoefficient: {TaxCoefficient}"); // You can display everything with one WriteLine
        }
        public override string ToString()
        {
            return $"{Id};{TypeName};{TaxCoefficient}";
        }
    }
}
