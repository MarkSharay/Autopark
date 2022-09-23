// See https://aka.ms/new-console-template for more information
using Autopark;


VehicleType[] types = new VehicleType[4]
{
    new VehicleType("Bus", 1.2),
    new VehicleType("Car", 1),
    new VehicleType("Rink", 1.5),
    new VehicleType("Tractor", 1.2)
};

Vehicle[] vehicles = new Vehicle[7]
{
    new Vehicle(types[0], new GasolineEngine(2, 8.1), "Volkswagen Crafter", "5427 AX-7", 2022, 2015, 376000, Colors.Blue, 75),
    new Vehicle(types[0], new GasolineEngine(2.18, 8.5), "Volkswagen Crafter", "6427 AA-7", 2500, 2014, 227010, Colors.White, 75),
    new Vehicle(types[0], new ElectricalEngine(50),"Electric Bus E321", "6785 BA-7", 12080, 2019, 20451, Colors.Green, 150),
    new Vehicle(types[1], new DieselEngine(1.6, 7.2),"Golf 5", "8682 AX-7", 1200, 2006, 230451, Colors.Gray, 55),
    new Vehicle(types[1], new ElectricalEngine(25), "Tesla Model S 70D", "E001 AA-7", 2200, 2019, 10454, Colors.White, 70),
    new Vehicle(types[2], new DieselEngine(3.2, 25), "Hamm HD 12 VV", null, 3000, 2016, 122, Colors.Yellow, 20),
    new Vehicle(types[3], new DieselEngine(4.75, 20.1), "МТЗ Беларус", "1145 AB-7", 1200, 2020, 109, Colors.Red, 135)
};

