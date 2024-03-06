using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2Demo
{
    public class Contractor : Person, ITerminate, IPayable
    {
        public Contractor(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public void Pay(int rate)
        {
            Console.WriteLine($"{FirstName} {LastName} will get paid ${40 * rate}");
        }

        public void Terminate(DateTime lastDay)
        {
            Console.WriteLine($"{FirstName} {LastName} last day will be {lastDay}.");
        }
    }
}
