using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SerializationCommonLibrary
{
    public class Student
    {
        [JsonPropertyOrder(1)]
        public string Name { get; set; }

        [JsonPropertyOrder(2)]
        public int Age { get; set; }
        
        [JsonPropertyOrder(3)]
        public DateTime Birthday { get; set; }
        [JsonPropertyOrder(0)]
        public int StudentId { get; set; }
        
        [JsonPropertyOrder(5)]
        public List<Course> Courses { get; set; }
    }
}
