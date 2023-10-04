using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.Exceptions
{
    public class InvalidAnimalException : Exception
    {
        public string ProblematicAnimal;
        public InvalidAnimalException() { }
        public InvalidAnimalException(string message) : base(message) { }
        public InvalidAnimalException(string message, string animal) : base(message) 
        {
            ProblematicAnimal = animal;
        }
    }
}
