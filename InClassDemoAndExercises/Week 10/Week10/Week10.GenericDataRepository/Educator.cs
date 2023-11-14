using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericRepositoryExercise
{
    public class Educator
    {
        public Educator(int id, string firstname, string lastname, string address)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Courses { get; set; }
    }
}
