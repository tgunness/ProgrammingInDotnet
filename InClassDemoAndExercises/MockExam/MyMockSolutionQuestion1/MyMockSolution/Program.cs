using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyMockSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assignmentManager = new AssignmentManager();

            while (true)
            {
                string menu =
    @"--Project Manager Portal--
Menu:
1. Display All Assignments (sorted by due date)
2. Add an Assignment
3. Remove an Assignment
4. Display Assignment that are past due (was due before today)
Enter choice:";

                Console.WriteLine(menu);
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        assignmentManager.SortAssignmentsByDueDate();
                        foreach(var assignment in assignmentManager.Assignments)
                        {
                            Console.WriteLine(assignment);
                        }
                        break;
                    case "2":
                        Console.WriteLine("AssignmentId:");
                        var assignmentId = Console.ReadLine().Trim();

                        Console.WriteLine("AssignmentName:");
                        var assignmentName = Console.ReadLine().Trim();

                        Console.WriteLine("DueDate:");
                        var dueDate = Console.ReadLine().Trim();

                        assignmentManager.AddAssignment(new Assignment()
                        {
                            AssignmentId = Convert.ToInt32(assignmentId),
                            AssignmentName = assignmentName,
                            DueDate = Convert.ToDateTime(dueDate)
                        });

                        break;
                    case "3":
                        Console.WriteLine("AssignmentId:");
                        var remveAssignmentId = Console.ReadLine().Trim();

                        assignmentManager.RemoveAssignment(Convert.ToInt32(remveAssignmentId));

                        break;
                    case "4":
                        foreach (var assignment in assignmentManager.GetAssignmentsDueBefore(DateTime.Now))
                        {
                            Console.WriteLine(assignment);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
