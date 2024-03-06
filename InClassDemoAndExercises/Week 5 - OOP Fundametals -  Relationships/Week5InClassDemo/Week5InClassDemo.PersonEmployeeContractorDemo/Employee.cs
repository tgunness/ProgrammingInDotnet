using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2Demo
{
    public class Employee : Person, IPayable, ITerminate
    {
        private int _hoursWorked;
        private int _rate;
        public Employee(int hoursWorked, string firstName, string lastName) : base(firstName, lastName)
        {
            _hoursWorked = hoursWorked;
        }
        public void Pay(int rate)
        {
            _rate = rate;
            Console.WriteLine($"{FirstName} {LastName} will get paid ${_hoursWorked*rate}");
        }

        public void Terminate(DateTime lastDay)
        {
            Console.WriteLine($"{FirstName} {LastName} last day will be {lastDay}. Servance will be {20*_rate}");
        }
    }
}
