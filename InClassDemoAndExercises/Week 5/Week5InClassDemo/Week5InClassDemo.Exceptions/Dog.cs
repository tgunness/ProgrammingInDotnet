namespace Week5InClassDemo.Exceptions
{
    public class Dog : IAnimal
    {
        private int _age;

        public Dog(int age) 
        {
            _age = age;
        
        }
        public string CalculateAge()
        {
            int convertedAge = 10 * _age;
            return $"Dog is {convertedAge} years old";
        }
    }
}
