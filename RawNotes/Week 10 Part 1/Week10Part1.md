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
# Announcements  

- Assignment Lab 3 due <span style="color:red;">**November 16th 2023 11:59pm**</span>
- Assignment Lab 4 due **November 26th 2023 11:59pm**
- Assignment Lab 5 due **December 8th 2023 11:59pm (no late days)**
  - See ["How to upload your game to Canvas"](https://www.youtube.com/watch?v=PNpVoE8w2r8)
---
<style scoped>section { font-size: 25px; }</style>
# Recap:
- Week 1 - Introduced .NET & Visual Studio
- Week 2 - Introduced C# Language
- Week 3 - Introduced Lists and LINQ
- Week 4 - OOP Fundamentals - Classes and Objects
- Week 5 - OOP Fundamentals - Relationships
- Week 6 - GUI - Forms and Events
- Week 7 - Midterm
- Week 8 Part 1 - Strings, Characters, Files & Streams, Serialization
- Week 8 Part 2 - Gaming I
- Week 9 Part 1 - Serialization, Classes File and Directory, Searching and Sorting
- Week 9 Part 2 - Gaming II
- **Week 10 Part 1 - Generics**
---

# Today

## Topics
- Generics

---

# Generics

Generics enable the creation of classes, methods, and interfaces that can work with any data type, which increases code reusability.

---

![Alt text](Wee10.1-image.png)

---

![Alt text](Wee10.1-image-1.png)

---

![Alt text](Wee10.1-image-2.png)

---

![Alt text](Wee10.1-image-3.png)

---

![Alt text](Wee10.1-image-4.png)

---

![Alt text](Wee10.1-image-5.png)

---

![Alt text](Wee10.1-image-6.png)

---

![Alt text](Wee10.1-image-7.png)

---

# Where you may use Generics

- Methods (`public void DisplayArray(T[] inputArray)`)
- Classes (`public class GenericList<T>`)
- Interfaces (`public interface IMonth<T> { }`)


--- 

# Generic Methods

```csharp

private static void DisplayArray(T[] inputArray)
{
  foreach(var element in inputArray)
  {
    Console.Write($" {element}");
  }
  Console.WriteLine();
}

```

---

# Generic Classes

```csharp 
public class Box<T>
{
    private T content;

    public void AddItem(T item)
    {
        content = item;
    }

    public T GetItem()
    {
        return content;
    }
}
```
---

# Generic Interfaces

```csharp
public interface ICalculator<T>
{
    T Add(T num1, T num2);
    T Subtract(T num1, T num2);
    T Multiply(T num1, T num2);
    T Divide(T num1, T num2);
}

```
---

# Type Constraints

- Lets say we want to write a Generic method called Maximum, but it can only work with types that implement the IComparable interface.
- We can use **Type Constraints**
- Type constraint is a way to specify limitations on the types that can be used as generic type parameters in a generic class, method, or interface. 

---

![Alt text](Wee10.1-image-8.png)

---
# Types Constraint (sample)

```csharp
public class MyClass<T> where T : class
{
    // Class-specific code
}
```
```csharp
public class MyInterface<T> where T : IMyInterface
{
    // Code that uses members of IMyInterface
}
```
```csharp
public class MyBaseClass<T> where T : MyBase
{
    // Code that assumes T is derived from MyBase
}
```
---
<style scoped>section { font-size: 20px; }</style>
# Exercise

**Objective:**
Implement a generic data repository that can store and retrieve objects of different types using C# Generics.

**Requirements:**

1. Create a generic class called `DataRepository<T>` that will serve as the data repository. This class should have the following methods:
   - `AddItem(T item)`: Adds an item of type `T` to the repository.
   - `GetItem(int index)`: Retrieves the item at the specified index.
   - `DisplayItems()`: Displays all items in the repository.

2. Implement a simple data class, e.g., `Person`, with a few properties.

3. Instantiate the `DataRepository<T>` class with different types, including the `Person` class.

4. Add several items of each type to the repository.

5. Retrieve and display the items from the repository.

6. Ensure that the generic class is flexible enough to handle various data types.


---
# Conclusion
## Topics
- Generics

## Next Class
- Gaming III

---

# END