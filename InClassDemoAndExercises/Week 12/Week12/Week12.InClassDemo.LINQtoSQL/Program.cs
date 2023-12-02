using System;
using System.Collections.Generic;
using System.Linq;
using Week12.InClassDemo.Data;

namespace Week12.InClassDemo.LINQtoSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new NorthWindDataContext())
            {
                //LINQ to get data in DB

                //using query expression
                var viNetOrdersByLinqQueryExpression =
                    from order in context.Orders
                    where order.CustomerID == "VINET" && order.EmployeeID == 2
                    select order;
                foreach (var order in viNetOrdersByLinqQueryExpression)
                {
                    Console.WriteLine(order.OrderID);
                }

                //using method expression
                var viNetOrderByLinqMethodQuery = context.Orders
                                                  .Where(order => order.CustomerID == "VINET" && order.EmployeeID == 2);            
                foreach (var order in viNetOrderByLinqMethodQuery)
                {
                    Console.WriteLine(order.OrderID);
                }

                //using query expression to filter data we get
                var viNetOrdersByLinqQueryExpressionDynamicTypeReturn =
                    from order in context.Orders
                    where order.CustomerID == "VINET" && order.EmployeeID == 2
                    select new { order.OrderID, order.OrderDate };

                foreach (var order in viNetOrdersByLinqQueryExpressionDynamicTypeReturn)
                {
                    Console.WriteLine(order.OrderID);
                }


                //showing the difference between ienumerable and iqueryable
                IEnumerable<Order> orders1 = context.Orders; //SELECT * FROM ORDERS;
                var order1 = orders1.Where(p => p.OrderID == 1).Count();
                Console.WriteLine(order1);

                IQueryable<Order> orders2 = context.Orders;
                var order2 = orders2.Where(p => p.OrderID == 1).Count(); //SELECT COUNT(*) FROM ORDERS WHERE ORDERID = 1;
                Console.WriteLine(order2);


            }
            Console.ReadLine();
        }
    }
}



/* References:
 * 
 * Setup SQL to LINQ: https://learn.microsoft.com/en-us/visualstudio/data-tools/linq-to-sql-tools-in-visual-studio2?view=vs-2022#install-the-linq-to-sql-tools
 * How to Query Information: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/how-to-query-for-information
 *
 */