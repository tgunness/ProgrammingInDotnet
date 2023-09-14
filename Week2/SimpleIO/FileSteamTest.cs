using System;
using System.IO;
using System.Text;

namespace SimpleIO
{
    /// <summary>
    /// This class uses the FileSteam class directly to read and write file
    /// 
    /// Using the FileStream directly is very rudimentary
    /// 
    /// **You should look to use StreamReader or StreamWriter whereever possible**
    /// </summary>
    public class FileSteamTest
    {
        public static void Run()
        {
            ReadFile();
            WriteFile();
        }

        public static void ReadFile()
        {
            Console.WriteLine("Reading from file using FileStream");
            FileStream fs = new FileStream("demo.txt", FileMode.Open, FileAccess.ReadWrite);


            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }

            fs.Close();

            Console.WriteLine("Don't use FileStream unless totally required. Please any key...");
            Console.ReadLine();
        }

        public static void WriteFile()
        {
            Console.WriteLine("Writing to file using FileStream");
            FileStream fs = new FileStream("demo.txt", FileMode.Open, FileAccess.ReadWrite);

            UTF8Encoding temp = new UTF8Encoding(true);
            string name = "Trishan Gunness";

            fs.Write(temp.GetBytes(name), 0, temp.GetByteCount(name));

            fs.Close();
            Console.WriteLine("Don't use FileStream unless totally required. Please any key...");
            Console.ReadLine();
        }
    }
}