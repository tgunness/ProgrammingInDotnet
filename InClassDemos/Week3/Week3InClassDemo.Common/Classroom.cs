using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3InClassDemo.Common
{
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
}
