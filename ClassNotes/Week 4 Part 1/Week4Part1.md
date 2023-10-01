---
marp: true
<style>
img[alt~="center"] {
  display: block;
  margin: 0 auto;
}
</style>
---

# [Programming in .NET](https://tgunness.github.io/ProgrammingInDotnet/Week4Part1.html) 
#### by Prof. Trishan Gunness 
---
# Recap:
- Week 1 - Introduced .NET & Visual Studio
- Week 2 - Introduced C# Language
- Week 3 - Introduced Lists and LINQ
- ***Week 4 & 5 - Fundamentals of OOP***
---

![bg center:80% 90%](<Blank 2 Grids Collage.png>) 
![bg center:800% 90%](Nest-Features.jpg)

---
# Today - Classes and Objects

By the end of this module you will be able to breakdown real world entities into Classes and Objects

---
# Procedural Programming

- Focuses on procedures and functions to organize code

- Code is divided into functions, where each function has a specific purpose

- Execution of the program has top-down design, start with main and break down into smaller functions.

- Make uses of flow control (for loop, if, while, etc) to control flow of execution

- Languages like C, Fortran and Pascal are built on procedural paradigm 

- Examples: calculators, cli utilities, control systems, etc.

--- 

# Disadvantages of Procedural:

- As program grows it becomes difficult to manage and maintain

- Sharing code with different projects difficult

- Rely on global variables to make data accessible across all functions

- Doesn't naturally map to real-world entities, making modeling hard
---
# Object Oriented Programming

- OOP is based on objects and everything is talked about in terms of objects
- Organizes code into reusable, self contained object
- Data and functions that operate on that data are encapsulated together in objects
- Represents real-world entities, making modeling easier
---

# What are Objects?
- Objects in a program are metaphors for real-world objects or entities (ie. Pen, Apple, etc.)
- Objects contains:
  - State - these are attributes of the object
  - Behavior - these are functionality or actions
- The process of creating objects is called **modeling**
---
# What is a Class?
- A Class is a blueprint of objects
- Whenever you create an Instance of a Class, you get an Object
- Class contains:
  - Instance Variables (Property) - attributes of the object
  - Instance Methods - functionality of the object
  - Constructors - outlines how to construct the object
---
# How to diagram Classes (UML Class Diagram)

![UML Diagram](image-1.png)

---
# [Exercise]() - Case Study
Old MacDonald Farm Inc. has reached out to your software development agency for their software development needs. 

**"At Old MacDonald Farm Inc., they have workers that picks Apples from their orchard Farm, places these Apples into Boxes, then loads those Boxes into Trucks which make deliveries across Canada."**

_Your first order of business is modeling their workflow._

Tasks:

1. Identify the real world objects within their workflow.
2. create UML Class Diagrams for the objects

---
# How to code Classes (C#)
```csharp 
public class Apple //<--Class Name
{
  public Apple() //<--Constructor
  {
    Color = "Red";  
  }

  public string Color { get; set; } //<--Instance Property
  public int Radius { get; set; } //<--Instance Property
  
  private int volume; //<--Instance Variable

  public int CalculateVolume() //<--Instance Method
  {
    volume =  4/3 * Math.PI * Radius * Radius * Radius;
  }
}
```
---
# Instance Variable, Instance Methods and Constructors

- **Instance Variables (Properties)** - they are the attributes or state of the Object
- **Instance Methods** - they are the functionality of the Object
- **Constructors** - they blueprint how to create the Object
---
# Access Modifiers (C#)
- Adds a level of protection by allowing the developer to tailor what data gets exposed and where. This is unknown as **Encapsulation**
- Within C# you have `public`, `private`, `protected internal`, `protected`, `internal`, `private protected`
![Alt text](image.png)
- `public` and `private` are the most commonly used 

   ```csharp 
  public string a { get; set; }
  private string b;
  ```
---
# Instantiating Objects

- To make an actual instance of a Class (aka "creating an Object"), it must be declared and memory allocated

```csharp

Apple a; //<--Declares 'a' as instance of Apple
a = new Apple();//<--'new' allocates memory for 'a'

Apple a = new Apple(); //<--Declares and allocates
```
---
# [Exercise]() - Case Study - cont.

_Now that we have complete modeling the workflow. We now need to create Class for all our real world objects._

Tasks:

1. Create a Class for each real world object that you've modeled previously (one per UML Class Diagram)

---
# Conclusion 

- OOP is based on objects
- An Object are metaphors for real-world objects or entities
- A Class is simply a blueprint of objects, that contains State (variables), Behavior (methods) and Constructor(s)
- With Access Modifiers we can encapsulate or restrict access to various components of an Object

# Next Class
- Deeper look at Object and Classes
- Destruction of Objects
- Inheritance


---
# Reminder

- **Lab Assignment 1 Due October 1st**
  - If you'd like a code review (feedback), please email me

---

# END



