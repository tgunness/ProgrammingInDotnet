# Student In Class Exercise - Method Syntax

Given the below code, please complete all `//TODO` items **using LINQ method syntax**

```csharp
public class Program
{
    static void Main(string[] args)
    {
        //Data Sources
        int[] numbers = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };
        Student[] students = new Classroom().Students;

        //Example - numbers greaterThanFive?
        var greaterThanFive = numbers.Where(a => a > 5);

        foreach(var num in greaterThanFive)
        {
            Console.WriteLine(num);
        }
        //TODO #1 - Console.WriteLine all numbers less than five


        //TODO #2 - Console.WriteLine the highest value in numbers


        //TODO #3 - Console.WriteLine all numbers, sorted largest to smallest (ie. 10, 9, 8, 7, etc.)


        //TODO #4 - Console.WriteLine all students that have passed the exam (ie. Exam grade greater than 50 is a pass)


        Console.ReadLine();
    }
}



public class Classroom
{
    public Student[] Students { get; set; }

    public Classroom()
    {
        Students = new Student[] {
                new Student(1, "Alice", "Johnson", 85),
                new Student(2, "Bob", "Smith", 92),
                new Student(3, "Charlie", "Brown", 78),
                new Student(4, "David", "Wilson", 88),
                new Student(5, "Eve", "Anderson", 95),
                new Student(6, "Frank", "Davis", 45),
                new Student(7, "Grace", "Lee", 76),
                new Student(8, "Henry", "Martinez", 91),
                new Student(9, "Isabella", "Taylor", 82),
                new Student(10, "Jack", "Rodriguez", 87),
                new Student(11, "Kate", "White", 93),
                new Student(12, "Liam", "Garcia", 84),
                new Student(13, "Mia", "Hernandez", 35),
                new Student(14, "Noah", "Lopez", 90),
                new Student(15, "Olivia", "Adams", 77),
                new Student(16, "Owen", "Clark", 94),
                new Student(17, "Sophia", "Turner", 81),
                new Student(18, "Thomas", "Scott", 86),
                new Student(19, "Victoria", "Walker", 75),
                new Student(20, "William", "Baker", 97),
            };
    }
}

public class Student
{
    public Student(int studentId, string firstName, string lastName, int grade)
    {
        StudentId = studentId;
        FirstName = firstName;
        LastName = lastName;
        ExamGrade = grade;
    }

    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ExamGrade { get; set; }

    public override string ToString()
    {
        return $"Student->ID:{StudentId},FName:{FirstName},LName:{LastName},ExamGrade:{ExamGrade}";
    }
}



```