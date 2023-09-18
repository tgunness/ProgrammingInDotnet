
# Academic Records Processing Exercise

You are given the code below which contain a Student class - each student class contains student's name, age, GPA, and major. 

Please complete the following:

1. Find the top three students with the highest GPAs and display their names and GPAs.

2. Calculate the average age of students in each Course and display the results along with the Course name.

3. Identify the course(s) with the highest average GPA and display the Course name and the corresponding average GPA.

4. Find the names of students who are majoring in Computer Science and have a GPA above 3.8.


```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }
    public string Course { get; set; }
}

public class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, GPA = 3.9, Course = "Computer Science" },
            new Student { Name = "Bob", Age = 21, GPA = 3.8, Course = "Engineering" },
            new Student { Name = "Charlie", Age = 19, GPA = 3.7, Course = "Computer Science" },
            new Student { Name = "David", Age = 22, GPA = 3.6, Course = "Engineering" },
            new Student { Name = "Eve", Age = 20, GPA = 3.9, Course = "Mathematics" },
            new Student { Name = "Frank", Age = 21, GPA = 3.7, Course = "Mathematics" },
        };

    }
}
```

