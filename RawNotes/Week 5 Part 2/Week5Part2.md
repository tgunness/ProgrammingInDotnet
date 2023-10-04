---
marp: true
<style>
img[alt~="center"] {
  display: block;
  margin: 0 auto;
}
</style>
---
# Programming in .NET
#### by Prof. Trishan Gunness 
---
# Recap:
- Week 1 - Introduced .NET & Visual Studio
- Week 2 - Introduced C# Language
- Week 3 - Introduced Lists and LINQ
- Week 4 - OOP Fundamentals - Classes and Objects
- ***Week 5 - OOP Fundamentals - Relationships***
---
# Recap Last Class

---

# Recap - Relationships

In real world and OOP, many objects have overlapping attributes and behaviors. 

We can form relationships in code to reduce code complexity and increase maintainability.

---
# Recap - Relationships in Code
In OOP, relationship is formed in a couple of ways

- Association
- Inheritance
  - Base Class
  - Abstract Class
  - Interface

---

# Recap - Association

When a class is composed of, or aggregates, other classes this is known as Association

Association represents the "HAS-A" relationship.

`Car` class "HAS-A" `Door` class
`University` class "HAS-A" `Department` class

---

# Recap - Association Code

```csharp
public class Car
{
public string Make { get; set; }
public Door CarDoor { get; set; }
public Car(string make, Door door) 
{
    Make = make;
    CarDoor = door;
}
public void Drive() {/*todo*/}
public void Assembly() {/*todo*/}
}

public class Door
{
private int Width {get; set;}
private int Height {get; set;}
public Door() {Width=20;Height=30;}
}
```
---

# Recap - Inheritance

When a class absorbs (inherits) an existing class's properties and methods, this is known as Inheritance

Inheritance represents the "IS-A" relationship.

`Teacher` "IS-A" `Employee`, and it can inherit properties like `EmployeeId`

---
# Recap - Inheritance Code

```csharp
public class Employee //inheriting from Object is done by compiler so not needed
{
  public Employee(){}
  public Employee(int ID) 
  { 
    /*...*/
  }
  public int EmployeeID {get;set;}
  public string FirstName {get;set;}
  public string LastName {get;set;}
}

public class Teacher : Employee
{
  public Teacher() {}
  public Teacher(int ID, string Faculty ) : base(ID) //base calls the base class constructor
  { 
    /*...*/  
  }
  private string Faculty {get; set;};
}
```
---

# Recap - Abstract Class and Interface

A Class can inherit from regular Class, but it can also inherit from Abstract Class or Interface

- **Regular Class** - derived class inherit all properties, methods, but can't override behavior in base class
- **Abstract Class** - derived class inherit properties, methods, but must add implementation to abstract elements in base class (ie. `public abstract int GetDate();`)
- **Interface** - derived class inherit no properties, methods, but must add implementation to everything defined in the interface 

---

# Recap - Abstract Class Code

```csharp
public abstract class Shape
{
  public string Color {get;set;}
  public int Length {get;set;}
  public int Width {get;set;}
  public abstract int CalculateArea();//no implementation
}

public class Rectangle : Shape
{
  public override int CalculateArea()
  {
    return Length * Width;
  }
}

```
---

# Recap - Interface Code

```csharp
public interface IDrawable
{
  void Draw();
}

public class Circle : IDrawable
{
  public void Draw()
  {
    //add implementation
  }
}
```
---

# Recap - Abstract and Interface - When to use

Use an **abstract class** when you want to provide a base structure with some shared code and fields for related classes. 

Use an **interface** when you want to define a contract specifying what derived classes must implement without providing any shared code.

---
# Today
- Multiple Inheritance 
- Polymorphism
- Exceptions


---
<style scoped>section { font-size: 20px; }</style>
# Multiple Inheritance 

You can only inherit from a Single Class (concrete or abstract) and you can and multiple Interfaces

```csharp 
    public class Employee : Person, IPayable, ITerminate
    {
        public Employee(string firstname, string lastname, int employeeId) : base(firstname, lastname)
        {
            EmployeeID = employeeId;
        }

        public int EmployeeID { get; set; }

        public override string ToString()
        {
            return $"Employee Details: " +
                   $"Firstname: {base.FirstName} " + //prop from Person
                   $"Lastname: {base.LastName} " + //prop from Person
                   $"EmployeeId: {this.EmployeeID}"; //prop from Employee
        }        

        public void Pay() //from IPayable
        {
            Console.WriteLine("Paid!");
        }

        public bool SaveVoidChequeu(object cheque) //from IPayable
        {
            Console.WriteLine("Saved bank information");
            return true;
        }

        public void TerminateEmployment() //from ITerminate
        {
            Console.WriteLine("Employment has ended.");
        }
    }

```
---

# Polymorphism

- Polymorphism is a Greek word that means “many shaped”.

- In OOP, Polymorphism is the ability of an object to take on many forms

- Any object that can pass the IS-A test, is considered to be polymorphic.

```csharp
public interface IFeedable { }
public class Animal { }
public class Deer : Animal, IFeedable { }
```

A Deer IS-A Animal
A Deer IS-A IFeedable
A Deer IS-A Deer
A Deer IS-A Object 

**Deer is considered to be polymorphic**

---

# Polymorphism - So What!?!

- Polymorphism is a powerful concept that allows polymorphic objects to be treated as any of their base or indirect base class, or any of their interfaces.

```csharp

Animal deer = new Deer();
IVegetarian deer2 = new Deer();
Object deer3 = new Deer();

```
---
# Polymorphic Code Demo - My Farm Animals


---



