using System.Collections.Generic;

namespace Week5InClassDemo.SchoolExercise
{
    public class Teacher : FacultyMember
    {
        public Teacher(string name, string lastname, int employeeId) : base(name, lastname, employeeId)
        {
        }

        public List<string> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}
