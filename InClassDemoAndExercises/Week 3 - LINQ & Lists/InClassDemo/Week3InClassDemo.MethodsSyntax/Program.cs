using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3InClassDemo.Common;

namespace Week3InClassDemo.MethodsSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Architecture();
            //MethodSyntax();
            //Examples();
        }

        #region Architecture
        static void Architecture()
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery = numbers.Where(num => num % 2 == 0);

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }

        #endregion

        #region MethodSyntax
        static void MethodSyntax()
        {
            // Data source.
            int[] datasource = { 90, 71, 82, 93, 75, 82 }; //int[] is of type Array class, Array class implements IEnumerable and thus queryable

            //Method Syntax Expression.

            IEnumerable<int> scoreQuery = datasource.Where(num => num > 2).Select(num => num);

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
        }
        #endregion

        #region Examples
        public static void Examples()
        {
            //Data Sources
            int[] numbers = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };
            Student[] students = new Classroom().Students;

            //Example - numbers greaterThanFive?
            var greaterThanFive = numbers.Where(a => a > 5);

            foreach(var num in greaterThanFive)
            {
                Console.WriteLine(num);
            }

            //Code - numbers sortedAscending
            var sorted = numbers.OrderBy(num => num);

            foreach(var s in sorted)
            {
                Console.WriteLine(s);
            }

            //Code - student firstname starting with J
            var jStudents = students.Where(a => a.FirstName.StartsWith("J"));

            foreach(var jStudent in jStudents)
            {
                Console.WriteLine(jStudent);
            }

            //Code - max int in numbers

            var maxNum = numbers.Max();

            Console.WriteLine(maxNum);




            //Projections

            var FnameLNameProjection =
                from student in students
                where student.FirstName.StartsWith("J")
                select student;

            foreach(var s in FnameLNameProjection)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }

        #endregion
    }
}
