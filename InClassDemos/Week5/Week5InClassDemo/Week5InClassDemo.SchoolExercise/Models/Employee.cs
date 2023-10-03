namespace Week5InClassDemo.SchoolExercise
{
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
}
