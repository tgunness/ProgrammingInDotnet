///*
//The following code example creates a temporary file and writes some text to it. The example then * opens the file, using T:System.IO.FileMode.Open; that is, if the file did not already exist, it * would not be created.
//*/

//using System;
//using System.IO;
//using System.Text;

//class Test
//{
//    public static void Main()
//    {

//        //FileStream fs = new FileStream("demo.txt", FileMode.Open, FileAccess.ReadWrite);


//        //byte[] b = new byte[1024];
//        //UTF8Encoding temp = new UTF8Encoding(true);

//        //while (fs.Read(b, 0, b.Length) > 0)
//        //{
//        //    Console.WriteLine(temp.GetString(b));
//        //}

//        //Console.ReadLine();




//    }
//}

//using System;
//using System.IO;

//class Test
//{
//    public static void Main()
//    {
//        try
//        {
//            ////old way - shouldn't do this, but you can
//            //FileStream file = new FileStream("demo.txt", FileMode.Open, FileAccess.Read);
//            //StreamReader sr = new StreamReader(file);
//            //string line;
//            //while ((line = sr.ReadLine()) != null)
//            //{
//            //    Console.WriteLine(line);
//            //}
//            //file.Close();
//            //Console.ReadLine();


//            ////using "using" and no FileStream
//            //using (StreamReader sr = new StreamReader("demo.txt"))
//            //{
//            //    string line;
//            //    while ((line = sr.ReadLine()) != null)
//            //    {
//            //        Console.WriteLine(line);
//            //    }
//            //}



//            //read complete file, one pass
//            using (StreamReader sr = new StreamReader("demo.txt"))
//            {
//                string line = sr.ReadToEnd();
//                Console.WriteLine(line);
//            }
//            Console.ReadLine();

//        }
//        catch (Exception e)
//        {
//            // Let the user know what went wrong.
//            Console.WriteLine("The file could not be read:");
//            Console.WriteLine(e.Message);
//        }
//    }
//}
//// ref: the foundation of this example can be seen here https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=netframework-4.8#examples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                    sw.Write(@"");
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadLine();
        }
    }
}
// ref: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netframework-4.8#examples