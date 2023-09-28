using System;

namespace Week4InClassDemo.Finalizer
{
    public class Person
    {

        private string name;
        public int age;
        public Person()
        {
            Console.WriteLine("created a person");
        }
        public Person(string name, int age): this()
        {
            this.name = name;

            this.age = age;

        }

        public Person(int age) : this("no name", age){}

        public void Speak()
        {
            Console.WriteLine(name);
        }

        public void Speak(int number)        
        {
            Console.WriteLine(name + number.ToString());
        }
    }
}
