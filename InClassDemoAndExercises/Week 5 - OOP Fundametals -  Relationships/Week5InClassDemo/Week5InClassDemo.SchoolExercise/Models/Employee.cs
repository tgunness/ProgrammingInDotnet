using System;
using Week5InClassDemo.SchoolExercise.Interface;

namespace Week5InClassDemo.SchoolExercise
{
    public class Employee : Person, IPayable, ITerminate
    {
        public Employee(string firstname, string lastname, int employeeId) : base(firstname, lastname)
        {
            EmployeeID = employeeId;
        }

        public int EmployeeID { get; set; }

        public override string ToString()
        {
            return $"Employee Details: " +
                   $"Firstname: {base.FirstName} " +
                   $"Lastname: {base.LastName} " +
                   $"EmployeeId: {this.EmployeeID}";
        }

        

        public void Pay()
        {
            Console.WriteLine("Paid!");
        }

        public bool SaveVoidChequeu(object cheque)
        {
            Console.WriteLine("Saved bank information");
            return true;
        }

        public void TerminateEmployment()
        {
            Console.WriteLine("Employment has ended.");
        }
    }
}
