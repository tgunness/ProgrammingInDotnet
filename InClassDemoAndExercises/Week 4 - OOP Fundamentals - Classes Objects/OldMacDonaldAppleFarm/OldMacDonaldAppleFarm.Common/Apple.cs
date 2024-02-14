using System;

namespace OldMacDonaldAppleFarm.Common
{
    public class Apple
    {
        public Apple(int rad, int weight, string type)
        {
            this.Radius = rad;
            this.Weight = weight;
            this.Type = type;
        }

        public int Radius { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }


        public int CalculateVolume()
        {
            int volume = (int)(4/3 * Math.PI * Radius * Radius * Radius);
            return volume;
        }
    }
}
