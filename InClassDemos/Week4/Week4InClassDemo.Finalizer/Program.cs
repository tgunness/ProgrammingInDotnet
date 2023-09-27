using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4InClassDemo.Finalizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "car1");
            Car car2 = new Car("Ford", "car2");
            Car car3 = new Car("Ford", "car3");
            DoStuff();
            Dealership dealer = new Dealership();

            Console.WriteLine("Done");

            #region using
            //using(var dealer2 = new Dealership())
            //{
            //    Console.WriteLine();
            //}
            #endregion
        }

        public static void DoStuff()
        {
            Car car7 = new Car("Ford", "car7");
            Car car8 = new Car("Ford", "car8");
            Car car9 = new Car("Ford", "car9");
        }
    }

    public class Car : IDisposable
    {
        private readonly string make;
        private readonly string model;
        private readonly string vinNumber;
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.vinNumber = Guid.NewGuid().ToString();

            Console.WriteLine($"{model} - Hypothetically I've opened my file");
        }

        ~Car()
        {
            Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine($"{model} - Hypothetically I've closed my file");
        }
    }

    public class Dealership : IDisposable
    {
        private List<Car> cars;
        public Dealership()
        {
            Console.WriteLine("Dealership - Hypothetically I've opened a DB Connection");
            Car car10 = new Car("Ford", "car10");
            Car car11 = new Car("Ford", "car11");
            Car car12 = new Car("Ford", "car12");
            cars = new List<Car>
            {
                car10,
                car11,
                car12
            };
        }

        public void Dispose()
        {
            Console.WriteLine("Dealership - Hypothetically I've closed my DB Connection");
        }

        ~Dealership()
        {
            Dispose();
        }
    }
}
