using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericBoxClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usage of the generic class
            Box<int> intBox = new Box<int>();
            intBox.AddItem(42);
            int intValue = intBox.GetItem();  
            Console.WriteLine(intValue); // intValue will be 42


            Box<string> stringBox = new Box<string>();
            stringBox.AddItem("Hello, Generics!");
            string stringValue = stringBox.GetItem();  
            Console.WriteLine(stringValue); // stringValue will be "Hello, Generics!"
        }
    }
}
