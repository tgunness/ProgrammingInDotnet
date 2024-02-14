using System;
using System.Runtime.CompilerServices;

namespace Week5InClassDemo.Polymorphism.Models
{

    public class Deer : Animal, IFeedable
    {
        public void HelloDeer()
        {
            Console.WriteLine("Hello World from Deer!");
        }

        public void Feed()
        {
            Console.WriteLine("Deer has been fed!");
        }
    }
}
