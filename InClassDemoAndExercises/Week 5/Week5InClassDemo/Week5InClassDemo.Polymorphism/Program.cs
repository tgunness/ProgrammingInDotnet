using System;
using System.Collections.Generic;
using Week5InClassDemo.Polymorphism.Models;

namespace Week5InClassDemo.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            Deer myDeer = new Deer();
            Puppy myPuppy = new Puppy();

            ////child treated as parent (Animal <-- Dog)[Dog IS-A Animal]


            ////parent can't be treated as child (Dog <--x-- Animal)[Animal IS-A Dog NOPE!]

            ////casting (Dog)Animal


            ////pro: grouping common types (myFarmAnimals) [before poly vs after poly]
            ////pro: can use typeof, is etc.

        }
    }
}
