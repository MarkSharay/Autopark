using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Collections
    {
        List<VehicleType> VehicleTypes { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Collections(string types, string vehicles, string rents)
        {
            VehicleTypes = ParseVehicleTypes(types);
            Vehicles = ParseVehicles(vehicles);
            LoadRents(rents);
            
        }
        public List<VehicleType> ParseVehicleTypes(string path)
        {
            List<VehicleType> vehicleTypes = new List<VehicleType> ();
            string[] VehicleTypesCsvLines = File.ReadAllLines(path);
            foreach (string line in VehicleTypesCsvLines)
            {
                vehicleTypes.Add (createVehicleType(line));
            }
            return vehicleTypes;
        }

        public List<Vehicle> ParseVehicles(string path) 
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string[] VehicleCsvLines = File.ReadAllLines(path);
            foreach (string line in VehicleCsvLines)
            {
                vehicles.Add(createVehicle(line));
            }
            
            return vehicles;
        }

        public void LoadRents(string path)
        {
            List<Rent> rents = new List<Rent>();
            string[] RentsCsvLines = File.ReadAllLines(path);
            foreach(string line in RentsCsvLines)
            {
                string[] parameters = line.Split(";");
                foreach(Vehicle vehicle in Vehicles)
                {
                    if(int.Parse(parameters[0]) == vehicle.Id)
                    {
                        vehicle.Rents.Add(new Rent(DateTime.Parse(parameters[1]), double.Parse(parameters[2])));
                    }
                }
            }
        }
        VehicleType createVehicleType(string csvVehicleType)
        {
            string[] parameters = csvVehicleType.Split(";");
            VehicleType vh = new VehicleType(int.Parse(parameters[0]), parameters[1], double.Parse(parameters[2]));
            return vh;
        }

        Vehicle createVehicle(string csvVehicle)
        {
            double forFormatExeption;
            string[] parameters = csvVehicle.Split(";");
            Vehicle vehicle = new Vehicle(int.Parse(parameters[0]), VehicleTypes[int.Parse(parameters[1])-1],
                    parameters[2], parameters[3], double.Parse(parameters[4]), int.Parse(parameters[5]),
                    int.Parse(parameters[6]), (Colors)Enum.Parse(typeof(Colors), parameters[7]),
                    EngineCreator.CreateEngine(parameters[8], double.TryParse(parameters[9], out forFormatExeption) ? double.Parse(parameters[9]) : 0,
                    double.TryParse(parameters[10], out forFormatExeption) ? double.Parse(parameters[10]) : 0),
                    int.Parse(parameters[11]));
            return vehicle;
        }

        public void InsertVehicle(int index, Vehicle vehicle)
        {
            Vehicles.Insert(index, vehicle);
        }

        public bool DeleteVehicle(int index)
        {
            if(index<0 || index >= Vehicles.Count)
            {
                return false;
            }
            else
            {
                Vehicles.RemoveAt(index);
                return true;
            }
        }

        public double SumTotalProfit()
        {
            double sum = 0;
            foreach(Vehicle vehicle in Vehicles)
            {
                sum += vehicle.GetTotalProfit();
            }
            return sum;
        }

        public void Print()
        {
            Console.WriteLine("{0, -5}{1, -15}{2, -25}{3, -15}{4,-15}{5,-10}{6,-10}{7,-10}{8,-10}{9,-10}{10,-15}",
                "Id", "Type", "Model",
                "Number", "Weight", "Year",
                "MileAge", "Color", "Income",
                "Tax/month", "Total profit");
            foreach(Vehicle vehicle in Vehicles)
            {

                string output = String.Format("{0,-5}{1,-15}{2,-25}{3, -15}{4,-15}{5,-10}{6,-10}{7,-10}{8,-10}{9,-10}{10,-15}",
                    vehicle.Id,
                    vehicle.Type.TypeName,
                    vehicle.Model,
                    vehicle.Number,
                    vehicle.Weight,
                    vehicle.Year,
                    vehicle.MileAge,
                    vehicle.Color,
                    vehicle.GetTotalIncome().ToString("0.00"),
                    vehicle.GetCalcTaxPerMonth().ToString("0.00"),
                    vehicle.GetTotalProfit().ToString("0.00")
                    );

                Console.WriteLine(output);
            }
            Console.WriteLine($"Total profit {SumTotalProfit().ToString("0.00")}");
        }
        public void Sort()
        {
            Vehicles.Sort();
        }
    }
}
