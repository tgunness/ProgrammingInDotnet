using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.Exceptions
{
    public class ProblematicAnimalException : Exception
    {
        public readonly string ProblemAnimal;
        public ProblematicAnimalException()
        {
            
        }

        public ProblematicAnimalException(string message) : base(message)
        {
            
        }

        public ProblematicAnimalException(string message, string animal):base(message)
        {
            ProblemAnimal = animal;

        }
    }
}
