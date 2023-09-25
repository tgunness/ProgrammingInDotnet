---
marp: true
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
# Today - Fundamentals of OOP - Classes and Objects

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
# Case Study
Old MacDonald Apple Farm Inc. has reached out to your software development agency for their software development needs. 

At their business, they have workers that picks Apples from their orchard farm, places the Apples into Boxes, then loads those Boxes into Trucks which make deliveries across Ontario Canada.

They have employed you to develop an application that can:
- Record the number of Apples that gets picked
- Output the number of Boxes required
- Output the number of Trucks required


Your company's first step in development is modeling. 

**Please create UML Class Diagrams for the main objects within this application.**





