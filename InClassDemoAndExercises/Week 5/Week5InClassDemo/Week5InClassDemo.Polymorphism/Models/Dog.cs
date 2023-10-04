using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.Polymorphism.Models
{
    public class Dog : Animal, IFeedable
    {

        public void HelloDog()
        {
            Console.WriteLine("Hello World from Dog!");
        }
        public void Feed()
        {
            Console.WriteLine("Dog has been fed!");
        }
    }
}
