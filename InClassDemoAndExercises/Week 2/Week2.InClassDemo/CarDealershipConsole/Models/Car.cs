using System;

namespace CarDealership.Models
{
    public class Car
    {
        public Car()
        {
            
        }
        public Car(string make, string model, double fuel, double mileage)
        {
            Make = make;
            Model = model;
            Fuel = fuel;
            Mileage = mileage;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Mileage { get; set; }

        public double CalculateFuelEfficiency()
        {
            return Fuel / Mileage * 100;
        }

        public override string ToString()
        {
            return $"[Make={Make},Model={Model},Fuel Used={Fuel},Mileage={Mileage} Fuel Efficiency = {CalculateFuelEfficiency():F}]"; //efficieny output makes use of Format specifier https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        }
    }
}