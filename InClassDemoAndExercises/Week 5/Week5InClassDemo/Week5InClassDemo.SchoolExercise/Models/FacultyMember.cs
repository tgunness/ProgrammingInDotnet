using System.Collections.Generic;

namespace Week5InClassDemo.SchoolExercise
{
    public class FacultyMember : Employee
    {
        public FacultyMember(string name, string lastname, int employeeId) : base(name, lastname, employeeId) { }

        public string Position { get; set; }
        public string Faculty { get; set; }

        public List<string> Duties { get; set; }
    }
}
