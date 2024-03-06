using System;
using System.IO;

namespace Week5InClassDemo.Exceptions
{
    public class Cat : IAnimal
    {
        private int _age;
        public Cat() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="ProblematicAnimalException">ProblematicAnimalException</exception>
        public Cat(int age)
        {
            if (age == 0)
                throw new ProblematicAnimalException("age can't be zero", "Cat");
            _age = age;
        }
        public string CalculateAge()
        {
            if (_age == 0)
                throw new ProblematicAnimalException("age can't be zero", "Cat");

            string val = "";
            int convertedAge = 0;
            try
            {
                convertedAge = 10 / _age;
                val = $"Cat is {convertedAge} years old";

            }
            catch (DivideByZeroException ex)
            {
                convertedAge = 0;
                val = $"age can not be zero {ex.Message}";
            }
            catch (Exception ex)
            {
                val = $"something happen but i dont know what {ex.Message}";
            }
            finally
            {
                Console.WriteLine("hit the finally block");
            }
            return val;
        }
    }
}
