using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Vehicle:IComparable<Vehicle>
    {
        public int Id { get; private set; }
        public List<Rent> Rents { get; private set; }
        public VehicleType Type { get; set; }
        public AbstractEngine EngineType { get; private set; }
        public string Model { get; private set; }
        public string Number { get; private set; }
        public double Weight { get; private set; }
        public int Year { get; private set; }
        public int MileAge { get; private set; }
        public Colors Color { get; private set; }
        public double Volume { get; private set; }

        public Vehicle(int id, VehicleType type,  string model, string number, double weight, int year, int mileAge, Colors color, AbstractEngine engineType, double volume)
        {
            Id = id;
            Type = type;
            EngineType = engineType;
            Model = model;
            Number = number;
            Weight = weight;
            Year = year;
            MileAge = mileAge;
            Color = color;
            Volume = volume;
            Rents = new List<Rent>();
        }

        public double GetTotalIncome()
        {
            double sum = 0;
            foreach(Rent rent in Rents)
            {
                sum += rent.Cost;
            }
            return sum;
        }
        public double GetTotalProfit()
        {
            return GetTotalIncome()-GetCalcTaxPerMonth();
        }
        public double GetCalcTaxPerMonth()
        {
            return (this.Weight * 0.00013) + (Type.TaxCoefficient * 30) + 5;
        }
        public int CompareTo(Vehicle v)
        {
  
            if(v != null)
            {
                if(this.GetCalcTaxPerMonth() < v.GetCalcTaxPerMonth())
                {
                    return -1;
                }else if(this.GetCalcTaxPerMonth() > v.GetCalcTaxPerMonth())
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
                throw new Exception("Null value was emitted");
            }
        }

        public override bool Equals(object? obj)
        {
            Vehicle vehicle = (Vehicle)obj;
            return this.Type.TypeName == vehicle.Type.TypeName && this.Model == vehicle.Model;
        }

        public override string ToString()
        {
            //return $"{Id};{Type};{Model};{Number};{Weight};{Year};{MileAge};{Color.ToString()};{EngineType.ToString()};{Volume}";
            return Model.ToString();
        }

    }
}
