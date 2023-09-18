//using System.Collections.Generic;
//using System.Linq;
//using System;
//using Week3InClassDemo.Common;

//public static void Examples()
//{
//    int[] data = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };

//    IEnumerable<int> greaterThan =
//        from num in data
//        where num > 5
//        select num;

//    foreach (int i in greaterThan)
//    {
//        Console.WriteLine(i);
//    }

//    IEnumerable<int> sortedAscending =
//        from num in data
//        orderby num ascending
//        select num;

//    foreach (int i in sortedAscending)
//    {
//        Console.WriteLine();
//    }


//    Student[] students = new Classroom().Students;

//    IEnumerable<Student> getByName =
//        from student in students
//        where student.FirstName.StartsWith("J")
//        select student;

//    foreach (Student student in getByName)
//    {
//        Console.WriteLine(student);
//    }
//}
