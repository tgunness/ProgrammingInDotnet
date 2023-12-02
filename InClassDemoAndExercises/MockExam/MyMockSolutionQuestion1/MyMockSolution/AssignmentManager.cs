using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMockSolution
{
    public class AssignmentManager
    {
        /* 
         * AddAssignment(Assignment assignment): Adds an assignment to the list.
           RemoveAssignment(int assignmentId): Removes an assignment from the list based on its AssignmentId.
           GetAssignmentsDueBefore(DateTime dueDate): Returns a list of assignments that are due before the specified date.
           SortAssignmentsByDueDate(): Sorts the assignments in the list based on their due dates in ascending order.
        */

        public List<Assignment> Assignments { get; set; }

        public AssignmentManager()
        {
            Assignments = new List<Assignment>();

            var a1 = new Assignment { AssignmentId = 1, AssignmentName = "Complete Project", DueDate = DateTime.Parse("2023-01-15") };
            var a2 = new Assignment { AssignmentId = 2, AssignmentName = "Review Code", DueDate = DateTime.Parse("2023-01-10") };
            var a3 = new Assignment { AssignmentId = 3, AssignmentName = "Prepare Presentation", DueDate = DateTime.Parse("2023-01-20") };

            Assignments.Add(a1);
            Assignments.Add(a2);
            Assignments.Add(a3);
        }


        public void AddAssignment(Assignment assignment)
        {
            if (assignment != null)
            {
                Assignments.Add(assignment);
            }
        }

        public void RemoveAssignment(int assignmentId)
        {
            //method1
            if (assignmentId != 0)
            {
                var assignmentsToRemove = Assignments.Where(a => a.AssignmentId == assignmentId).ToList();
                foreach (var removeMe in assignmentsToRemove)
                {
                    Assignments.Remove(removeMe);
                }
            }

            //method2
            //if (assignmentId != 0)
            //{
            //    _assignments.RemoveAll(a => a.AssignmentId == assignmentId); //this liner to remove all with that id.
            //}
        }

        public List<Assignment> GetAssignmentsDueBefore(DateTime dueDate)
        {
            //method 1 - method linq
            var ret1 = Assignments.Where(a => a.DueDate < dueDate);

            //method2 - query language syntax
            var ret2 = from assignment in Assignments
                       where assignment.DueDate < dueDate
                       select assignment;

            return ret1.ToList();
        }

        public void SortAssignmentsByDueDate()
        {
            //method 1
            Assignments.Sort((a1, a2) => DateTime.Compare(a1.DueDate,a2.DueDate));

            ////method 2
            //_assignments.OrderBy(a => a.DueDate);
        }
    }
}
