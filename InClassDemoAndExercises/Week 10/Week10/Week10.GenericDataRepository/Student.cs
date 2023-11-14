using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericRepositoryExercise
{
    public class Student
    {
        public Student(int id, string firstname, string lastname, string address)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}
