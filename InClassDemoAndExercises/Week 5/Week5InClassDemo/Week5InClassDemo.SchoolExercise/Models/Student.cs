using System.Collections.Generic;

namespace Week5InClassDemo.SchoolExercise
{
    public abstract class Student : Person
    {
        public List<string> Course { get; set; }
        public List<string> Programs { get; set; }
        public bool IsGraduated = false;
        public abstract bool HasGraduated();
    }
}
