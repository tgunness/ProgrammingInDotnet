using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIO
{
    /// <summary>
    /// This class highlights the proper way to write to a file using StreamWriter
    /// </summary>
    public class StreamWriterTest
    {
        public static void Run()
        {
            Console.WriteLine("Writing to file using StreamWriter.");
            using (StreamWriter sw = new StreamWriter("demo.txt"))
            {
                sw.WriteLine("Hello World!!");
            }
            Console.WriteLine("StreamWriter is generally used to write to file. Please any key to continue...");
            Console.ReadLine();
        }
    }
}
