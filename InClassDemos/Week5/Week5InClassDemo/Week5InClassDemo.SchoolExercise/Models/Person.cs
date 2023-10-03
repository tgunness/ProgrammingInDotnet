namespace Week5InClassDemo.SchoolExercise
{
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
}
