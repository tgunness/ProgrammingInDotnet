using System;

namespace Week5InClassDemo.Exceptions
{
    public class Cat : IAnimal
    {
        private int _age;
        public Cat() { }
        public Cat(int age)
        {
            if (age == 0)
                throw new InvalidAnimalException("age can not be zero", "Cat");

            _age = age;
        }
        public string CalculateAge()
        {
            try
            {
                int convertedAge = 10 / _age;
                return $"Cat is {convertedAge} years old";
            }
            catch(DivideByZeroException e)
            {
                return "unknown due to divide zero";
            }
            catch(ArgumentException e)
            {
                return "unknown due to invalid arg";
            }
            catch(Exception e)
            {
                return "unknown, for reasons unknown";
            }
        }
    }
}
