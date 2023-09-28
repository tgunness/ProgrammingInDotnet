using System;
using System.Collections.Generic;
using Week4InClassDemo.Finalizer;

namespace Week4InClassDemo.Finalizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "this is a, test";

            int wordCount = test.WordCount();

            Console.WriteLine(wordCount);

            Person p = new Person(10);
            Console.WriteLine(p.AgeMultipler(30));


            Console.ReadLine();

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
        public string Make { get; set; } 
        private readonly string make;

        private readonly string model;
        private readonly string vinNumber;
        public Car() { }
        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
            this.vinNumber = Guid.NewGuid().ToString();           
        }

        ~Car() //finalizer
        {
            Dispose();
        }

        public void Dispose() //IDisposable
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
