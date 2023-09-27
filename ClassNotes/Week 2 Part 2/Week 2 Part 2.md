# Week 2 Part 2

# Review Last Class Exercise 

## Car Dealership Part 1
We will demo one [working example](https://github.com/tgunness/ProgrammingInDotnet/tree/main/Week2/CarDealership)

# Introduction to Windows Form GUI

## Demo - Car Dealership Part 2
Using the Models within Car Dealership Part 1, we will build a Win Form GUI App.

Our app will contain:
- Button "List All Cars"
- Button "Car with best mileage"
- Button "Cars built by Ford"
- Ouput Textbox for all output
- Button "Exit"


# Simple File I/O

## Stream Class
C# has `Stream` abstract class which provides standard method to transfer bytes (read, write, etc.) to a source. 

Concrete Stream classes include:
- **FileStream - files** 
- MemoryStream - memory
- BufferedStream - works with other streams to improve performance
- NetworkStream - network sockets

    
## FileStream

`FileStream file = new FileStream("path.txt", FileMode, FileAccess, FileShare);`
- `path` string - path to file
- `FileMode` enum - Append | Create | CreateNew | Open | OpenOrCreate | Truncate
- `FileAccess` enum - Read | ReadWrite | Write
- `FileShare` enum - declares how to share this file with others (typically `FileShare.None` is chosen)

[(ref)](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.open?view=netframework-4.8#system-io-file-open(system-string-system-io-filemode-system-io-fileaccess-system-io-fileshare))

```
/*
The following code example creates a temporary file and writes some text to it. The example then * opens the file, using T:System.IO.FileMode.Open; that is, if the file did not already exist, it * would not be created.
*/

using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        // Create a temporary file, and put some data into it.
        string path = Path.GetTempFileName();
        using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

        // Open the stream and read it back.
        using (FileStream fs = File.Open(path, FileMode.Open))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(b,0,b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
    }
}

```

## Stream helpers
`StreamWriter` - StreamWriter is a helper class for writing a string to a Stream
`StreamReader` - StreamReader is a helper class for reading characters from a Stream

FileStream vs StreamReader:

**[StreamReader/StreamWriter]** <--Read/Write String--> **[FileStream]** <--Read/Write bytes--> **[Physical File]**

**StreamReader**
```
using System;
using System.IO;

class Test
{
    public static void Main()
    {
        try
        {
            //old way
            FileStream file = new FileStream("TestFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader data = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            data.Close();

            
            //using "using" and no FileStream
            using (StreamReader sr = new StreamReader("TestFile.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            //read complete file, one pass
            using (StreamReader sr = new StreamReader("TestFile.txt"))
            {
                string line = sr.ReadToEnd();
            }

        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
// ref: the foundation of this example can be seen here https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=netframework-4.8#examples
```
**StreamWriter**

```
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
        }
    }
}
// ref: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netframework-4.8#examples
```


# Lab 1 - Introduction

[Lab 1 - Out of Sorts](https://mycanvas.mohawkcollege.ca/courses/92925/pages/lab-assignment-1?module_item_id=4762945)

**Due: Sept 24th 2023 11:59pm**


