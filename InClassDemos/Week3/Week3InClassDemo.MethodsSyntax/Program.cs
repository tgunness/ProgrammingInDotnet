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
            Architecture();
            MethodSyntax();
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

            //Code - numbers greaterThanFive?


            //Code - numbers sortedAscending


            //Code - student firstname starting with J


            //Code - max int in numbers
        }

        #endregion
    }
}
