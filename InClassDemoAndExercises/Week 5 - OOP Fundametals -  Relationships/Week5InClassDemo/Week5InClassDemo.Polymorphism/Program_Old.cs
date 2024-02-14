using System;
using System.Collections.Generic;
using Week5InClassDemo.Polymorphism.Models;

namespace Week5InClassDemo.Polymorphism
{
    internal class Program_Old
    {
        static void NotMain(string[] args)
        {
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            Deer myDeer = new Deer();
            Puppy myPuppy = new Puppy();

            ////child treated as parent (Animal <-- Dog)[Dog IS-A Animal]
            Animal myAnimal_isA_Animal = new Animal(); //<--PLEASE DONT NAME VARIABLES LIKE THIS (ie. ISA, HASA)!!!
            Animal myDog_isA_Animal = new Dog();
            Animal myCat_isA_Animal = new Cat();
            Animal myDeer_isA_Animal = new Deer();
            Animal myPuppy_isA_Animal = new Puppy();
            IFeedable myDog_isA_Feedable = new Dog();

            ////parent can't be treated as child (Dog <--x-- Animal)[Animal IS-A Dog NOPE!]
            //Dog myAnimal_isNOTa_Dog = new Animal();

            ////casting (Dog)Animal
            //Dog myDogC = myDog_isA_Animal; //can't just assign, you need cast
            Dog myDogA = (Dog)myDog_isA_Animal;
            Dog myDogB = (Dog)myDog_isA_Feedable;


            //pro: grouping common types (myFarmAnimals) [before poly vs after poly]
            //pro: can use typeof, is etc.
            List<Animal> myAnimals = new List<Animal>()
            {
                myAnimal_isA_Animal,
                myDog_isA_Animal,
                myCat_isA_Animal,
                myDeer_isA_Animal,
                myPuppy_isA_Animal
            };

            HaveMyAnimalSayHello(myAnimals);


            IFeedable myDog_isA_IFeedable = new Dog();
            IFeedable myCat_isA_IFeedable = new Cat();
            IFeedable myDeer_isA_IFeedable = new Deer();
            IFeedable myPuppy_isA_IFeedable = new Puppy();

            List<IFeedable> animalsToFeed = new List<IFeedable>()
            {
                myDog_isA_Feedable,
                myCat_isA_IFeedable,
                myDeer_isA_IFeedable,
                myPuppy_isA_IFeedable
            };

            FeedMyAnimals(animalsToFeed);

            Console.ReadLine();
        }

        
        public static void PrintMyAnimals(Dog d, Cat c, Deer de, Puppy p)
        {
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(de);
            Console.WriteLine(p);
        }

        public static void PrintMyAnimals(List<Animal> myAnimals)
        {
            foreach(Animal myanimal in myAnimals)
            {
                Console.WriteLine(myanimal);
            }
        }      

        public static void HaveMyAnimalSayHello(List<Animal> myAnimals)
        {
            foreach (Animal myAnimal in myAnimals)
            {
                myAnimal.HelloWorld();
                if (myAnimal is Dog)
                    ((Dog)myAnimal).HelloDog();
                else if (myAnimal is Cat)
                    ((Cat)myAnimal).HelloCat();
                else if (myAnimal is Deer)
                    ((Deer)myAnimal).HelloDeer();
                else if(myAnimal is Puppy)
                    ((Puppy)myAnimal).HelloPuppy();
                else
                    Console.WriteLine("Unknown animal!");
            }
        }

        public static void FeedMyAnimals(List<IFeedable> myAnimals)
        {
            foreach (IFeedable myAnimal in myAnimals)
            {
                myAnimal.Feed(); //no need to get types, because I know the contract within interface
            }
        }
    }
}
