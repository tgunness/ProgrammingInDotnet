using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3InClassDemo.QueryExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                select score; //must end with select or group

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }

            // Output: 93 90 82 82
        }
    }
}
