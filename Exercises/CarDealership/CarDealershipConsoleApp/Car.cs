using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipConsoleApp
{
    public class Car
    {
        public Car(string make, string model,double fuel, double mileage)
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
            return $"[{Make}, {Model}, Fuel Used= {Fuel} Mileage = {Mileage} Fuel Efficiency = {CalculateFuelEfficiency()}]";
        }

    }
}
