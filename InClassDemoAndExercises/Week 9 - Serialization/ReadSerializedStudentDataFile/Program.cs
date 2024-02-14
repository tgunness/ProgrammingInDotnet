using SerializationCommonLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ReadSerializedStudentDataFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            var filePath = "c:\\temp\\collegePrograms.json";
            string jsonString = File.ReadAllText(filePath);

            List<CollegeProgram> programs = JsonSerializer.Deserialize <List<CollegeProgram>>(jsonString);

            foreach(var program in programs)
            {
                foreach(var student in program.Students)
                {
                    if(student.Age >= 18)
                    {
                        Console.WriteLine(student.Name);
                    }
                }
            }

            #region snippets
            //List<CollegeProgram> programs = JsonSerializer.Deserialize<List<CollegeProgram>>(jsonString);

            //foreach(var program in programs)
            //{
            //    Console.WriteLine(program.Name);
            //    foreach(var student in program.Students)
            //    {
            //        if (student.Age >= 18)
            //        {
            //            Console.WriteLine($"student Name: {student.Name} is {student.Age} years old");
            //            foreach (var course in student.Courses)
            //            {
            //                Console.WriteLine(course.Name);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("this student is too young");
            //        }
            //    }
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
