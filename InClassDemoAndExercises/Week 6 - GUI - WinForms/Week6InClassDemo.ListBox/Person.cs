using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6InClassDemo.ListBox
{
    public class Person
    {

        public Person(string firstName, string lastName, int sinNum, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            SinNumber = sinNum;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SinNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
