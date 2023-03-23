using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Entities
{
    public class Employee
    {
        public Employee() { }
        public Employee(int id, string firtname, string lastname, string address, string postalcode) 
        {
            Id = id;
            FirstName = firtname;
            LastName = lastname;
            Address = address;
            PostalCode = postalcode;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{Id},{FirstName},{LastName},{Address},{PostalCode}";
        }
    }
}
