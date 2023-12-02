using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week12.InClassDemo.DataAccessLayer;

namespace Week12.InClassDemo.GenericRepositoryDemo
{
    // CRUD - Create, Read, Update or Delete

    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new NorthWindDataContext();
            var orderRep = new GenericRepository<Order>(context);

            foreach (var item in orderRep.GetAll())
            {
                Console.WriteLine(item.OrderID);
            }

            Console.WriteLine(orderRep.Get("OrderId", 10255));

            Console.WriteLine(context.Orders.Where(a => a.OrderID == 11077).First().OrderID);

            Console.ReadLine();
        }
    }
}
