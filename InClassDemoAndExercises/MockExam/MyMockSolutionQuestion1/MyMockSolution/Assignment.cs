using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMockSolution
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return $"AssignmentId: {AssignmentId}, AssignmentName:{AssignmentName}, DueDate: {DueDate}";
        }

    }
}
