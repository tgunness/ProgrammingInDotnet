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
        public DbSet<OrderDetail> OrderDetails { get; set; }

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

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        // Add other properties...

        public virtual Order Order { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthWindDbContext("server=.\\SQLEXPRESS;Database=Northwind2;User Id=sa;Password=Password01!"))
            {
                foreach (var order in context.Orders.Include(a=>a.OrderDetails))
                {
                    Console.WriteLine($"{order.OrderID} for {order.CustomerID} with ship name {order.ShipName}");
                    foreach (var details in order.OrderDetails)
                    {
                        Console.WriteLine($"orderdetail id: {details.ProductId}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}