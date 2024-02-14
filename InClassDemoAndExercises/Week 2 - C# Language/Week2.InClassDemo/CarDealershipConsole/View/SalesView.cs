using CarDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership.View
{
    public class SalesView
    {
        private readonly int _sleepTimer = 2000;

        private Dealership _dealership;
        public SalesView(Dealership dealership)
        {
            _dealership = dealership;
        }

        public void Display()
        {
            //while(true) is an infinite loop; I allow this because option 4, does `return;` which exits function
            while (true) 
            {                
                switch (DisplayMainMenu())
                {
                    case "1":
                        DisplayShowAllCarsMenu();
                        break;
                    case "2":
                        DisplayShowMostFuelEfficientCar();
                        break;
                    case "3":
                        DisplayShowCarsByMake("Ford");
                        break;
                    case "4":
                        DisplayGoodbyeCar();
                        return;
                    default:
                        DisplayInvalidOption();
                        break;
                }
            }
        }

        private string DisplayMainMenu()
        {
            Console.Clear();
            Console.Write(Constants.MainMenu);
            return Console.ReadLine();
        }

        private void DisplayShowCarsByMake(string make)
        {
            Console.Clear();
            Console.WriteLine($"Here are your {make} cars:");
            foreach (var car in _dealership.GetAllCarsByMake(make))
                Console.WriteLine($"\t{car}");
            DisplayWaitToContinue();
        }

        private void DisplayShowMostFuelEfficientCar()
        {
            Console.Clear();
            Console.WriteLine($"Your most fuel efficient car is:");
            Console.WriteLine($"\t{_dealership.GetCarWithBestMileage()}");
            DisplayWaitToContinue();
        }

        private void DisplayShowAllCarsMenu()
        {
            Console.Clear();
            Console.WriteLine("Here are all cars in inventory:");
            foreach (var car in _dealership.GetAllCars())
                Console.WriteLine($"\t{car}");
            DisplayWaitToContinue();
        }

        private void DisplayWaitToContinue()
        {
            Console.WriteLine("\r\n\r\nPress any key continue...");
            Console.ReadLine();
        }

        private void DisplayInvalidOption()
        {
            Console.WriteLine("Invalid Selection, please try again...");
            Thread.Sleep(_sleepTimer);
        }

        private void DisplayLogoutMessage()
        {
            Console.Clear();
            Console.Write("Goodbye");
            Thread.Sleep(_sleepTimer);
        }

        private void DisplayGoodbyeCar()
        {
            foreach(string c in Constants.GetAsciiCars())
            {
                Console.Clear();
                Console.Write(c);
                Thread.Sleep(100);
            }
            Thread.Sleep(_sleepTimer);   
        }
    }
}
