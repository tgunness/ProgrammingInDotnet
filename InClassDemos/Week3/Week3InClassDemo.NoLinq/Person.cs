using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3InClassDemo
{
    public class Person
    {
        public Person(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
