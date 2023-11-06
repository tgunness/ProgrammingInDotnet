using System.Collections.Generic;

namespace SerializationCommonLibrary
{
    public class CollegeProgram
    {
        
        public List<Student> Students { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        
        public CollegeProgram()
        {
            Students = new List<Student>();
        }
    }
}
