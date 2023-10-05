using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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
            Animal myDogAnimal = new Dog();
            Animal myCatAnimal = new Cat();
            Animal myDeerAnimal = new Deer();
            Animal myPuppyAnimal = new Puppy();

            ////parent can't be treated as child (Dog <--x-- Animal)[Animal IS-A Dog NOPE!]
            //Dog myAnimalDog = new Animal();


            ////casting (Dog)Animal
            Dog newDog = (Dog)myDogAnimal;
            Cat newCat = (Cat)myCatAnimal;
            //Dog newCat2= (Cat)myCatAnimal;
            Dog myPuppyNew = (Puppy)myPuppyAnimal;
            Object myObh = (Object)myPuppyAnimal;

            List<Animal> myFarmAnimals = new List<Animal>()
            {
                myDogAnimal,
                myCatAnimal,
                myDeerAnimal,
                myPuppyAnimal
            };

            SayHelloFromAllAnimalFromList(myFarmAnimals);

            IFeedable myDogAnimalFeed = new Dog();
            IFeedable myCatAnimalFeed = new Cat();
            IFeedable myDeerAnimalFeed = new Deer();
            IFeedable myPuppyAnimalFeed = new Puppy();

            List<IFeedable> myFeedAnimals = new List<IFeedable>()
            {
                myDogAnimalFeed,
                myCatAnimalFeed,
                myDeerAnimalFeed,
                myPuppyAnimalFeed
            };

            Console.ReadLine();
        }

        public static void FeedFarmAnimal(List<IFeedable> myFeedAnimals)
        {
            foreach(IFeedable a in myFeedAnimals)
            {
                a.Feed();
            }
        }

        public static void SayHelloFromAllAnimalFromList(List<Animal> myAnimals)
        {
            foreach(Animal myAnimal in myAnimals)
            {

                if (myAnimal is Puppy)
                    ((Puppy)myAnimal).HelloPuppy();
                else if(myAnimal is Dog)
                    ((Dog)myAnimal).HelloDog();
                else if (myAnimal is Deer)
                    ((Deer)myAnimal).HelloDeer();
                else if (myAnimal is Cat)
                    ((Cat)myAnimal).HelloCat();
                else
                    Console.WriteLine("Animal Is Unknown!");
            }
        }

        //public static void SayHelloFromAllAnimal(Dog[] d, Cat[] c, Deer[] de, Puppy[] p)
        //{
        //    p.HelloPuppy();
        //    d.HelloDog();
        //    de.HelloDeer();
        //    c.HelloCat();
        //}
    }
}
