using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipConsoleApp
{
    internal class Program
    {
        public static string mainMenu =
@"
CAR APPLICATION
=================
Menu
1 - Display all Cars
2 - List car with best mileage
3 - List all Ford Cars
4 - Exit app

Enter Option:";

        static void Main(string[] args)
        {
            bool doloop = true;
            Dealership dealership = new Dealership();
            while(doloop)
            {
                Console.Clear();
                Console.Write(mainMenu);
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        foreach (Car c in dealership.GetAllCars())
                        {
                            Console.WriteLine(c);
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        Car car = dealership.GetBestMileageCar();
                        Console.Clear();
                        Console.WriteLine(car);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        foreach (Car c in dealership.GetCarByMake("Ford"))
                        {
                            
                            Console.WriteLine(c);
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        doloop = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
