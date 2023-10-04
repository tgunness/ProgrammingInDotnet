using System;

namespace Week5InClassDemo.Exceptions
{
    public class Cat : IAnimal
    {
        private int _age;
        public Cat() { }
        public Cat(int age)
        {
            _age = age;
        }
        public string CalculateAge()
        {
            int convertedAge = 10 / _age;
            return $"Cat is {convertedAge} years old";
        }
    }
}
