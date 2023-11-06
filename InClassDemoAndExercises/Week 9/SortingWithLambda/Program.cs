using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 22 },
            new Person { Name = "David", Age = 28 }
        };

        // Sort the list of Person objects by Name using the Sort() method with a lambda expression
        people.Sort((person1, person2) => person1.Name.CompareTo(person2.Name));

        // Display the sorted list
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        Console.ReadLine();
    }
}
