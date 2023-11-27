using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Week12.InClassDemo.DesignerMarkupLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new NorthwindContextDataContext())
            {
                foreach(var order in context.Orders)
                {
                    Console.WriteLine(order.OrderID);
                    foreach(var orderDetails in order.OrderDetails)
                    {
                        Console.WriteLine(orderDetails.UnitPrice);
                    }
                }


                IEnumerable<Order> orders = context.Orders; //SELECT * FROM ORDERS;
                var orderOne = orders.Where(p => p.OrderID == 1);

                IQueryable<Order> orders2 = context.Orders;
                var orderOne2 = orders.Where(p => p.OrderID == 1); //SELECT * FROM ORDERS WHERE ORDERID = 1;
            }


            

            Console.ReadLine();

        }
    }
}
