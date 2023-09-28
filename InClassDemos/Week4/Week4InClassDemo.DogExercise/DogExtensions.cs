using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week4InClassDemo.DogExercise
{
    public static class DogExtensions
    {
        /// <summary>
        /// Get all dog name starting with j and output good
        /// </summary>
        /// <param name="d"></param>
        public static void IsGood(this Dog d)
        {
            if(d.Name.ToLower().StartsWith("j"))
            {
                Console.WriteLine($"{d.Name} is good");
            }
        }

        public static void IsGood(this IEnumerable<Dog> dogs)
        {
            foreach(Dog d in dogs)
            {
                d.IsGood();
            }
        }

        public static void IsGroomed(this Dog d)
        {
            if(d.IsGroomed)
                Console.WriteLine($"{d.Name} has been groomed");
        }

        public static void IsGroomed(this IEnumerable<Dog> dogs)
        {
            foreach(Dog d in dogs)
            {
                d.IsGroomed();
            }
        }


    }
}
