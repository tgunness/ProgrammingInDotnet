using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIO
{
    /// <summary>
    /// This class highlights the proper way to read from a file using StreamReader
    /// </summary>
    public class StreamReaderTest
    {
        public static void Run()
        {
            Console.WriteLine("Reading from file using StreamReader.");
            using (StreamReader sr = new StreamReader("demo.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("StreamReader is generally used to read file. Please any key to continue...");
            Console.ReadLine();
        }
    }
}
