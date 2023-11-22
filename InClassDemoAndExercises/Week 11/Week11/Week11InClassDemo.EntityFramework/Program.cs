using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Week11InClassDemo.EntityFramework
{
    public class NorthWindDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public NorthWindDbContext(string connectionString) : base(connectionString)
        {

        }
    }

    // Entity class representing an Order
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        // Add other properties...
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new NorthWindDbContext("server=.\\SQLEXPRESS;Database=Northwind2;User Id=sa;Password=Password01!"))
            {
                foreach(var order in context.Orders)
                {
                    Console.WriteLine(order.OrderID);
                }
            }
        }
    }
}
