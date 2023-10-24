using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReviewQuestion2
{
    public class Electronic : IShippable
    {
        public int SKU { get; }
        public string Name { get; }
        public string Description { get; }
        public int Quantity { get; set; }

        public int Weigth { get; set; }

        public Electronic(int sku, string name, string desc, int weigth, int quantity)
        {
            if (sku == 0)
            {
                throw new ArgumentException("Please provide valid SKU");
            }

            if(weigth <= 0)
            {
                throw new ArgumentException("Weigth must be greater than 0");
            }
            SKU = sku;
            Name = name;
            Description = desc;
            Quantity = quantity;
            Weigth = weigth;
        }

        public override string ToString()
        {
            var f = this;
            return ($"{f.Quantity} {f.Name} will take {f.GetTotalDeliveryDays()} days");
        }

        public int GetTotalDeliveryDays()
        {
            if(Weigth < 10)
            {
                return 1 * Quantity; //1 day per quantity
            }
            else
            {
                return 2 * Quantity; //2 day per quantity
            }
        }

        public bool ValidateShipment()
        {
            if (SKU != 0 && Quantity > 0 && Weigth > 0)
                return true;
            else
                return false;
        }
    }
}
