using System;
using System.Collections.Generic;

namespace SerializationCommonLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int StudentId { get; set; }
        public List<Course> Courses { get; set; }
    }
}
