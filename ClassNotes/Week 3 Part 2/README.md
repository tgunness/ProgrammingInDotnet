# Week 3 - LINQ and List Collection

# RECAP - Week 3 Part 1 - Introduction to LINQ

- LINQ is an integrated query language that can be used various data sources (objects, sql or xml)
- Has two ways of constructing queries:

    | Query Syntax  | Method Syntax |
    | ------------- | ------------- |
    |<pre>static void Main()<br>{<br>int[] numbers = newint[7]{0,1,2,3,4,5,6};<br><br>var numQuery=<br>from num in numbers<br>where num % 2<br>select num;<br><br>foreach(int num in numQuery)<br>{<br>  Console.Write(num);<br>}<br>}<br></pre>|<pre>static void Main()<br>{<br>int[] numbers=newint[7]{0,1,2,3,4,5,6};<br><br>var numQuery = numbers.Where(num => num % 2);<br><br>foreach(int num in numQuery)<br>{<br>  Console.Write(num);<br>}<br>}<br></pre>
- All queries, by default, has Deferred Execution (will query data at time of evaluation)
- Lambdas, aka anonymous functions, are used with Method Syntax
- Query syntax is preferred, used Method syntax only when needed


# Week 3 Part 2 - List Collections





# Introduction to Collections 

- System.Collections.Generic;
- List<T> (T represents type; this is the generic type; comes from System.Collections.Generic; doesn't need to be resize like Arrays)
    - Add
    - AddRange
    - Capacity
    - Clear
    - Contains
    - Count
    - IndexOf
    - Insert (element at specific index)
    - Remove
    - RemoveAt (element at specific index)
    - RemoveRange
    - Sort
    - TrimExcess
- 