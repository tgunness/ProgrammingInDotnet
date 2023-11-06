using SerializationCommonLibrary;
using System;
using System.Collections.Generic;

namespace WriteSerializedStudentDataFile
{
    public class SchoolDataSource
    {
        public List<CollegeProgram>  GenerateCollegePrograms()
        {
            var ret = new List<CollegeProgram>();
            for(int i = 0; i <= 1; i++)
            {
                ret.Add(new CollegeProgram()
                {
                    ID = i,
                    Name = $"Program {i}",
                    Students = GenerateStudents()
                });
            }

            return ret;
        }

        public List<Course> GenerateCourse()
        {
            List<Course> ret = new List<Course>();
            for(int i=0; i <= 3; i++)
            {
                ret.Add(new Course { ID = i, Name = $"Course {i}" });
            }
            return ret;
        }

        public List<Student> GenerateStudents()
        {
            List<Student> ret = new List<Student>();
            for(int i=0;i<=2; i++)
            {
                ret.Add(new Student
                {
                    Name = $"Student {i}",
                    Age = 18,
                    Birthday = DateTime.Now,
                    Courses = GenerateCourse(),
                    StudentId = i
                });
            }
            return ret;
        }
    }
}
