using System;

namespace CarDealership
{
    internal class Car
    {
        public Car()
        {
            
        }

        public string Make { get; internal set; }
        public string Model { get; internal set; }
        public double Fuel { get; internal set; }
        public double Mileage { get; internal set; }

        internal double CalculateGasMileage()
        {
            return Fuel / Mileage * 100;
        }

        public override string ToString()
        {
            return $"[Make={Make},Model={Model},Fuel Used={Fuel},Mileage={Mileage} Fuel Efficiency = {CalculateGasMileage()}]";
        }
    }
}