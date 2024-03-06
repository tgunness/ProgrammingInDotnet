using System;
using System.Collections.Generic;

namespace Week5InClassDemo.Exceptions
{
    public class Vet
    {
        private List<IAnimal> _animals;
        public Vet()
        {
            try
            {
                _animals = new List<IAnimal>()
                            {
                                new Dog(10),
                                new Dog(11),
                                new Cat(24),
                                new Dog(8),
                                new Cat()
                            };

                Cat c = new Cat(20);
            }
            catch (Exception ex)
            {

            }
        }
        public void PrintAllAnimals()
        {
            foreach (var animal in _animals)
            {
                try
                {
                    Console.WriteLine(animal.CalculateAge());
                }
                catch (ProblematicAnimalException e)
                {
                    Console.WriteLine($"oops you've got a problematic {e.ProblemAnimal}!!");
                }

            }
        }
    }
}
