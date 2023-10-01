---
marp: true
<style>
img[alt~="center"] {
  display: block;
  margin: 0 auto;
}
</style>
---

# Introduction to .NET and C#

---
<style scoped>section { font-size: 20px; }</style>
# What is .NET

.NET is a free, open-source, and cross-platform framework developed by Microsoft for building various types of software applications. It provides a comprehensive set of tools, libraries, and runtime environments that enable developers to create applications ranging from web and desktop applications to mobile apps and cloud services. The core components of .NET include:

```
1. **Common Language Runtime (CLR)**: The CLR is a key part of .NET that manages memory, handles execution, and provides various services to make it easier for developers to write and run applications.

2. **Base Class Library (BCL)**: The BCL is a collection of pre-built classes and libraries that provide fundamental functionality like data access, file I/O, and networking, saving developers from reinventing the wheel for common tasks.

3. **Languages**: .NET supports multiple programming languages, with C# being the most popular. Other languages like F#, Visual Basic, and more can also be used to write .NET applications.

4. **ASP.NET**: A framework for building web applications and services using .NET.

5. **Entity Framework**: An Object-Relational Mapping (ORM) framework that simplifies database access.

6. **Xamarin**: A cross-platform development framework for building mobile apps for iOS, Android, and macOS using .NET.

7. **.NET Core**: An open-source, cross-platform variant of .NET designed for modern development. It was later merged into the unified .NET 5 and .NET 6.

8. **.NET 5 and .NET 6**: These versions unify the .NET ecosystem, combining .NET Core, .NET Framework, and Xamarin into a single platform, making it easier for developers to write code that runs on multiple platforms.

```
.NET allows developers to write code in their language of choice and deploy it on various platforms, including Windows, macOS, and Linux. It's widely used for building enterprise applications, web services, cloud-based solutions, and more. With its strong ecosystem, tooling support, and continuous development by Microsoft and the open-source community, .NET remains a popular choice for modern software development.

---
<style scoped>section { font-size: 20px; }</style>
## What is C#

C# (pronounced "C sharp") is a modern, high-level, and object-oriented programming language developed by Microsoft. It was introduced in the early 2000s as part of the .NET initiative and has since become one of the most popular languages for building a wide range of software applications. C# is known for its simplicity, robustness, and versatility, making it a favorite choice for developers in various domains, including web development, desktop applications, mobile app development, and game development.

Here are some key characteristics and features of C#:

```
1. **Object-Oriented**: C# is a fully object-oriented language, which means it supports principles like encapsulation, inheritance, and polymorphism. This helps in writing clean and organized code.

2. **Type-Safe**: C# is statically typed, meaning that type checking is done at compile-time. This helps catch many errors before the code is even executed.

3. **Modern Syntax**: C# offers a modern and expressive syntax, making it easier to read and write code compared to older languages like C++.

4. **Managed Code**: C# applications are compiled into Intermediate Language (IL) code and executed within the Common Language Runtime (CLR), which manages memory and provides features like garbage collection.

5. **Rich Standard Library**: C# includes a comprehensive Base Class Library (BCL) that provides pre-built classes and libraries for common tasks, such as file I/O, networking, and data manipulation.

6. **Cross-Platform Development**: With the introduction of .NET Core (now part of .NET 5 and later), C# has become cross-platform, allowing developers to build applications that run on Windows, macOS, and Linux.

7. **Strongly Typed**: C# enforces strong type checking, reducing the likelihood of runtime errors.

8. **Asynchronous Programming**: C# has built-in support for asynchronous programming using the `async` and `await` keywords, which is essential for developing responsive and scalable applications.

9. **Versatile Ecosystem**: C# can be used to develop a wide range of applications, including web applications with ASP.NET, mobile apps with Xamarin, desktop applications with Windows Forms or WPF, and even game development with Unity.

10. **Continuously Evolving**: Microsoft continues to invest in C# by releasing new versions with enhancements and features to keep the language competitive and up-to-date.
```
C# has a thriving developer community, extensive documentation, and a wealth of third-party libraries and tools, making it an excellent choice for both beginners and experienced programmers looking to build modern, efficient, and maintainable software.

---
# Hello World in C#

A "Hello, World!" program in C# is a simple example that demonstrates the basic structure of a C# program. It prints the message "Hello, World!" to the console. Here's how you can create a "Hello, World!" app in C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```
---
<style scoped>section { font-size: 20px; }</style>
# Here's a breakdown of what this program does:

- `using System;`: This line includes the `System` namespace, which provides access to fundamental types and classes like `Console` for input and output operations.

- `class Program`: This defines a class named `Program`. In C#, the `Main` method, which is the entry point of the program, must be contained within a class. In this case, we named the class `Program`.

- `static void Main()`: This is the `Main` method, which is the starting point of the program. It is marked as `static` because it doesn't require an instance of the `Program` class to be called. It is also marked as `void` because it doesn't return a value. In this simple example, it takes no arguments.

- `Console.WriteLine("Hello, World!");`: This line uses the `Console.WriteLine` method to print the text "Hello, World!" to the console. The `WriteLine` method adds a newline character after the text, so each call to it starts on a new line.

To run this program, you'll need a development environment like Visual Studio or Visual Studio Code with the C# extension installed. Alternatively, you can use the command-line C# compiler (csc) to compile and run the program.

Once you run the program, it will display "Hello, World!" in the console output. This simple example is often used as a starting point when learning a new programming language, as it provides a quick way to verify that your development environment is set up correctly and that you can write, compile, and run code.