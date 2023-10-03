using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo.SchoolExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        public Person(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
        }

        public Person()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    public class  Employee : Person 
    {
        public Employee(string name, string lastname, int employeeId)
        {
            this.FirstName = name;
            this.LastName = lastname;
            EmployeeID = employeeId;
        }

        public int EmployeeID { get; set; }
    }

    public class FacultyMember : Employee
    {
        public string Position { get; set; }
        public string Faculty { get; set; }

        public List<string> Duties { get; set; }
    }

    public class Teacher : FacultyMember 
    {
        public List<string> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Admin : FacultyMember { }

    public abstract class Student : Person
    {
        public List<string> Course { get; set; }
        public List<string> Programs { get; set; }
        public bool IsGraduated = false;
        public abstract bool HasGraduated();
    }

    public class GraduatedStudent : Student
    {
        public override bool HasGraduated()
        {
            IsGraduated = true;
            return IsGraduated;
        }
    }
}
