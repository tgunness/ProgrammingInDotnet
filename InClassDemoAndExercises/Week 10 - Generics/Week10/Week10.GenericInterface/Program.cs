using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericInterface
{
    internal class Program
    {
        static void Main()
        {
            // Integer Calculator
            ICalculator<int> intCalculator = new GenericCalculator<int>();
            Console.WriteLine("Integer Calculator:");
            Console.WriteLine($"Add: {intCalculator.Add(5, 3)}");
            Console.WriteLine($"Subtract: {intCalculator.Subtract(5, 3)}");
            Console.WriteLine($"Multiply: {intCalculator.Multiply(5, 3)}");
            Console.WriteLine($"Divide: {intCalculator.Divide(6, 3)}");

            // Double Calculator
            ICalculator<double> doubleCalculator = new GenericCalculator<double>();
            Console.WriteLine("\nDouble Calculator:");
            Console.WriteLine($"Add: {doubleCalculator.Add(5.5, 3.2)}");
            Console.WriteLine($"Subtract: {doubleCalculator.Subtract(5.5, 3.2)}");
            Console.WriteLine($"Multiply: {doubleCalculator.Multiply(5.5, 3.2)}");
            Console.WriteLine($"Divide: {doubleCalculator.Divide(6.0, 3.0)}");

            Console.ReadLine();
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            var max = a;

            if (a.CompareTo(b) > 0)
                max = b;

            return max;
        }
    }
}
