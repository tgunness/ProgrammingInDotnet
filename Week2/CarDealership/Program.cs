using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Fuel = 40,
                Mileage = 550
            };
            cars[1] = new Car()
            {
                Make = "Ford",
                Model = "Mustang",
                Fuel = 45,
                Mileage = 432
            };
            cars[2] = new Car()
            {
                Make = "VW",
                Model = "Golf",
                Fuel = 34,
                Mileage = 667
            };
            cars[3] = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Fuel = 39,
                Mileage = 600
            };
            cars[4] = new Car()
            {
                Make = "Chevrolet",
                Model = "Cruz",
                Fuel = 40,
                Mileage = 525
            };

            Menu(cars);
        }

        static void Menu(Car[] cars)
        {
            var menu =
@"
Car Application
=================
Menu
1 - Display all Cars
2 - List car with best mileage
3 - List all Ford Cars
4 - Exit app

Enter Option:
".Trim();
            
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.Write(menu);
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        foreach (var car in cars)
                            Console.WriteLine(car);
                        Console.WriteLine("Please Key Continue....");
                        Console.ReadLine();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Goodbye");
                        Thread.Sleep(2000);

                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
