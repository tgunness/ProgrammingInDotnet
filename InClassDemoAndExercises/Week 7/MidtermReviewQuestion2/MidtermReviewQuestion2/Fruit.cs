using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReviewQuestion2
{
    public class Fruit : IShippable
    {
        public int SKU { get; }
        public string Name { get; }
        public string Description { get; }

        public int Quantity { get; set; }

        public Fruit(int sku, string name, string desc, int quantity)
        {
            if(sku == 0)
            {
                throw new ArgumentException("Please provide valid SKU");
            }

            if(quantity > 100)
            {
                throw new ArgumentException("Quantity greater than 100 is not allowed");
            }

            SKU = sku;
            Name = name;
            Description = desc;
            Quantity = quantity;
        }

        public override string ToString()
        {
            var f = this;
            return ($"{f.Quantity} {f.Name} will take {f.GetTotalDeliveryDays()} days");
        }

        public int GetTotalDeliveryDays()
        {
            return Convert.ToInt32(0.5 * Quantity);
        }

        public bool ValidateShipment()
        {
            if (SKU != 0 && Quantity > 0)
                return true;
            else
                return false;
        }
    }
}
