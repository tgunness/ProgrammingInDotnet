using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3InClassDemo.Common;

namespace Week3InClassDemo.QueryExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Architecture();
            //QuerySyntax();
            //Examples();
            Example.Examples();
        }

        #region Architecture
        static void Architecture()
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                (from num in numbers
                where (num % 2) == 0
                select num);

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }

        #endregion

        #region QuerySyntax
        static void QuerySyntax()
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 }; //int[] is of type Array class, Array class implements IEnumerable and thus queryable

            // Query Syntax Expression.
            var scoreQuery = //query variable
                from score in scores //required
                where score > 80       // insert optional clauses here 
                orderby score descending
                select score; //required, must end with select or group



            // Execute the query to produce the results
            foreach (var testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
        }
        #endregion

        #region Examples
        public static void Examples()
        {
            
        }

        #endregion
    }
}
