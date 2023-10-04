using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.Polymorphism.Models
{
    public class Puppy : Dog
    {
        public void HelloPuppy()
        {
            Console.WriteLine("Hello World from Puppy!");
        }
    }
}
