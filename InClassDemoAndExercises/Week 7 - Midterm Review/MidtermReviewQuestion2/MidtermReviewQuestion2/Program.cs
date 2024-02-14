using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReviewQuestion2
{
    public class Carrier
    {
        public List<IShippable> AllShipments;

        static void Main(string[] args)
        {
            Carrier carrier = new Carrier();

            carrier.AllShipments = new List<IShippable>()
            {
                new Fruit(20,"Apple","Red Apple",10),
                new Electronic(30,"Iphone","Iphone x",30,10),
                new Electronic(40,"TV","85 TV",5,200),
                new Fruit(50,"Lemon","Yellow Lemon",6),
                new Fruit(51,"Grape","Green Grape",8),
                new Electronic(80,"Laptop","Thinkpad",9,50),
                new Electronic(82,"Keyboard","keys",2,5),
                new Fruit(96,"Pear","Brown Pear",80)
            };

            foreach (IShippable shipment in carrier.AllShipments)
            {
                if (shipment.ValidateShipment() == false)
                    continue;
                else if(shipment is Fruit)
                {
                    Fruit f = (Fruit)shipment;
                    Console.WriteLine(f);
                }
                else if (shipment is Electronic)
                {
                    Electronic e = (Electronic)shipment;
                    Console.WriteLine(e);
                }
            }

            //(“Everything will take 201 days”)
            int totalDays = carrier.AllShipments.Where(a=>a.ValidateShipment() == true)
                                                .Sum(a => a.GetTotalDeliveryDays());
            
            Console.WriteLine($"Everything will take {totalDays} days");

            Console.ReadLine();
        }
    }
}
