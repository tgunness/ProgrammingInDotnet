using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4InClassDemo.DogExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                 new Dog("Charlie",10),
                 new Dog("Buddy",4),
                 new Dog("Bailey",5),
                 new Dog("Bella",7),
                 new Dog("Joey",9),
                 new Dog("Max",3),
                 new Dog("Cooper",2),
                 new Dog("Jojo",87),
                 new Dog("Duke",65),
                 new Dog("Milo",61),
            };

            dogs.IsGroomed();
            dogs.IsGood();

            Console.ReadLine();

        }
    }
}
