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

            string fname = "Trishan";
            string lname = "Gunness";

            string fullname = "Mr. " + fname + " Middle Name " + lname;

            string fullname2 = String.Format("Mr. {0} {1}", fname, lname);

            string fullName = $"Mr. {fname} {lname}";
            string filePath = @"C:\test\2";

            string menu = 
$@"Console application
1. List Stuff
2. Edit Stuff
3. Move Stuff
Please select stuff {fullName}:
";


            Console.WriteLine(menu);

            Thread.Sleep(10000);



        }
    }
}
