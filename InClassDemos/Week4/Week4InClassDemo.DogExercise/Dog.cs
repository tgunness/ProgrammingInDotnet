using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4InClassDemo.DogExercise
{
    /// <summary>
    /// Class representing a real world Dog
    /// </summary>
    public class Dog : IDisposable
    {
        #region Attributes
        /// <summary>
        /// Dog's age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Has dog been groomed
        /// </summary>
        public bool IsGroomed { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
        }

        private readonly string name;

        #endregion

        #region Constructors
        /// <summary>
        /// Generates new dog with random string for name and age zero
        /// </summary>
        public Dog() : this(Guid.NewGuid().ToString(), 0)
        {
            
        }

        /// <summary>
        /// Generates new dog with param string for name and param age for age 
        /// </summary>
        /// <param name="name">Doggie's name</param>
        /// <param name="age">Doggie's age</param>
        public Dog(string name, int age) 
        {
            this.name = name;
            Age = age;
            IsGroomed = true;
        }
        #endregion

        #region Behaviours 

        /// <summary>
        /// Outputs "groomed" and set IsGroomed True
        /// </summary>
        public void Groom()
        {
            IsGroomed = true;
            Console.WriteLine("groomed");
        }

        /// <summary>
        /// Outputs "groomed {x} hours" and set IsGroomed True
        /// </summary>
        /// <param name="hours"></param>
        public void Groom(int hours)
        {
            IsGroomed = true;
            Console.WriteLine($"grooming took {hours} hours");
        }

        #endregion

        #region Finalizers
        ~Dog()
        {
            Dispose();
        }

        /// <summary>
        /// outputs name + deceased
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine($"{Name} deceased");
        }
        #endregion
    }
}
