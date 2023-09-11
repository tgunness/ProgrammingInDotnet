using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//this is inline comment

namespace Week2.InClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine(name);
            var a = 12;
            long b = a;
            float c = a;
            double d = a;
            decimal currency = a;

            int e = Convert.ToInt32(b);
            int f = int.Parse(name);
            int g;
            bool canConvert = int.TryParse(name, out g);


            if(int.TryParse(name, out int gg))
            {
                Console.WriteLine(gg);
            }
            Thread.Sleep(2000);


            decimal myMoney = 300.5m;
            float myRadius = 3.145f;

            int aa = 12;
            var bb = 12;
            var cc = "";

        }
    }
}
