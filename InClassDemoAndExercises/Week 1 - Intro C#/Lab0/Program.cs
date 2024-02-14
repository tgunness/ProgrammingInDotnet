using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number1;
            string input;

            System.Console.Write("Enter a number and hit enter, press q to quit: ");
            input = Console.ReadLine();

            while (int.TryParse(input, out number1))
            {
                total += number1;
                System.Console.WriteLine("\ttotal " + total);
                System.Console.WriteLine("more : ");
                input = Console.ReadLine();
            }
        }
    }
}
