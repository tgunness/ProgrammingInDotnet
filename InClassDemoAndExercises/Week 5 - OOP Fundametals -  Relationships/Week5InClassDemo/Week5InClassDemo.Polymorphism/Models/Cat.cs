using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.Polymorphism.Models
{
    public class Cat : Animal, IFeedable
    {
        public void Feed()
        {
            Console.WriteLine("Cat has been fed!");
        }

        public void HelloCat()
        {
            Console.WriteLine("Hello World from Cat!");
        }


    }
}
