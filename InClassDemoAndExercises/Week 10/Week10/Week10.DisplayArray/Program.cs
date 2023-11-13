using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.DisplayArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("Array intArray contains: ");
            DisplayArray(intArray);
            Console.WriteLine("Array doubleArray contains: ");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains: ");
            DisplayArray(charArray);
        }
    }
}
