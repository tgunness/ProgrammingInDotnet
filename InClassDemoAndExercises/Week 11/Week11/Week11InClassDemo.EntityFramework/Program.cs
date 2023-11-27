using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Week11InClassDemo.EntityFramework;

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
        public string ShipName { get; set; }


        // Add other properties...
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthWindDbContext("server=.\\SQLEXPRESS;Database=Northwind2;User Id=sa;Password=Password01!"))
            {
                foreach (var order in context.Orders)
                {
                    Console.WriteLine($"{order.OrderID} for {order.CustomerID} with ship name {order.ShipName}");
                }
            }
            Console.ReadLine();
        }
    }
}