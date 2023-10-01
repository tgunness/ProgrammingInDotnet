---
marp: true
<style>
img[alt~="center"] {
  display: block;
  margin: 0 auto;
}
</style>
---
# Week 3 - LINQ and List Collection

# Week 3 Part 1 - Introduction to LINQ
# Agenda
- Overview
- Architecture
- Query Syntax
- Exercise - Query Syntax
- Method Syntax
- Exercise - Method Syntax
- Best Practices
- Academic Records Processing Exercise

# Overview
- LINQ stands for Language Integrated Query
- It's a set of features in C# for querying and manipulating data
- It allows to write queries directly in code (you can even write SQL like code)
    - query = set of instructions that describe what data to retrieve from a given data source
- LINQ operates on various data sources:
    - LINQ to Objects - query in-memory collections likes arrays, lists and dictionaries
    - LINQ to SQL - query and manipulate data in relational database
    - LINQ to XML - simplifies XML processing
- Has flexibility, providing you with two ways of writing queries
    - Query Syntax
    - Method Syntax

# Architecture
## Background
- LINQ supports the data types that inherit from IEnumerable (ie. `Array`, `List`, etc.)
    -  Data types that support IEnumerable or a derived interface such as the generic IQueryable are called **_queryable types_**.
- When declaring LINQ query variable, you can use the `var` keyword to instruct the compiler to infer the type of a query variable at compile time
    - This is useful when doing projections, or dynamic types
- All LINQ query operations has three parts 
    1. Obtain that data source
    2. Create the query
    3. Execute the query

        ```csharp
        static void Main()
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
        ```
        ![Alt text](linq-query-complete-operation.png)
## Deferred Execution (aka Lazy Evaluation)
- The query variable itself only stores the query commands. The actual execution of the query is deferred until you iterate over the query variable in a foreach statement.
- Because the query variable itself never holds the query results, you can execute it as often as you like.
    - This becomes very relevant in LINQ to SQL where you want to query for the latest data at various stages. 
## Immediate Execution (aka Eager evaluation)
- You can force immediate execution by specifying an extension method (ie. `.ToArray()`, `.ToList()`, `.Max()`, `.Count()`, etc)

# Query Syntax
- Query syntax are often more readable 
- A query expression consists of a set of clauses written in a declarative syntax similar to SQL
- Keywords used in these clauses ([ref](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords))
    - `from` - Specifies a data source and a range variable (similar to an iteration variable).
    - `where` - Filters source elements based on one or more Boolean expressions separated by logical AND and OR operators ( && or || ).
    - `select` - Specifies the type and shape that the elements in the returned sequence will have when the query is executed.
    - `group` -	Groups query results according to a specified key value.
    - `into` -	Provides an identifier that can serve as a reference to the results of a join, group or select clause.
    - `orderby` - Sorts query results in ascending or descending order based on the default comparer for the element type.
    - `join` - Joins two data sources based on an equality comparison between two specified matching criteria.
    - `let` - Introduces a range variable to store subexpression results in a query expression.
    - `in` - Contextual keyword in a join clause.
    - `on` - Contextual keyword in a join clause.
    - `equals` - Contextual keyword in a join clause.
    - `by` - Contextual keyword in a group clause.
    - `ascending` - Contextual keyword in an orderby clause.
    - `descending` - Contextual keyword in an orderby clause.
- A query syntax expression must begin with a `from` clause and must end with a `select` or `group` clause. 
  
  Between the first `from` clause and the last `select` or `group` clause, it can contain one or more of these optional clauses: `where`, `orderby`, `join`, `let` and even additional `from` clauses. 

    ```csharp
    // Data source.
    int[] scores = { 90, 71, 82, 93, 75, 82 }; //int[] is of type Array class, Array class implements IEnumerable and thus queryable

    // Query Syntax Expression.
    IEnumerable<int> scoreQuery = //query variable
        from score in scores //required
        where score > 80 // optional
        orderby score descending // optional
        select score; //must end with select or group

    // Execute the query to produce the results
    foreach (int testScore in scoreQuery)
    {
        Console.WriteLine(testScore);
    }

    // Output: 93 90 82 82
    ```

# Student In Class Exercise - Query Syntax
See exercise [here](https://github.com/tgunness/ProgrammingInDotnet/blob/main/Exercises/Week%203/LINQQuerySyntaxExercise.md)


# Method Syntax (aka Method Extension Syntax or Fluent)
- Method Syntax uses extension methods to construct the query
- Sample of Methods:
    - `.Where()` - filters a sequence of values based on a predicate.
    - `.Count()` - returns the number of elements in a sequence
    - `.Max()` - returns the maximum value in a sequence
    - `.Min()` - returns the minimum value in a sequence
    - `.Sum()` - computes the sum of a sequence
    - `.Select()` - projects each element of a sequence into a new form
    - A full list of methods can be found [in the Enumerable Class spec](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=netframework-4.8)
- Method Syntax vs Query Syntax
    - At compile time, query syntax expressions are converted to method calls
    - Any query that can be expressed by using query syntax can also be expressed by using method syntax.
    - Some query operations, such as `Count` or `Max`, have no equivalent query expression clause and must therefore be expressed as a method call. 
        - All query syntax expressions can be methods but not all methods can be query syntax expressions
    - There is no semantic or performance difference between the two different forms. 
- 
    ```csharp
    static void Main()
    {
        int[] numbers = { 5, 10, 8, 3, 6, 12};

        //Method syntax:
        IEnumerable<int> numQuery2 = numbers.Where(num => num > 2);

        foreach (int i in numQuery2)
        {
            Console.Write(i + " ");
        }

        // Keep the console open in debug mode.
        Console.WriteLine(System.Environment.NewLine);
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
    ```
- Method syntax is also called 'fluent' syntax because it flows logically and intuitively, and allows methods to be combined simply
    - A method return can be piped to the input of next method
        ```csharp
        IEnumerable<int> numQuery2 = numbers.Where(num => num > 2).OrderBy(n => n);
        ```    
## Lambda Expressions
- Lambda expressions is another core concept in C#, which are anonymous functions used for inline code blocks
- Method syntax makes use of Lambda expressions
- The body of the lambda is just the same as the expression in query syntax or in any other C# expression or statement
- Express Lambda: `(input-parameters) => expression`
    - `.Where(num => num > 2)`
- Statement Lambda: `(input-parameters) => { <sequence-of-statements> }`    
    ```csharp
    .Where(num => { 
        if(num > 2) return num;
      })`  
    ``` 
    
- `=>` is the lambda operator, which is read as "goes to"
- learn more on Lambda [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)     
         

# Mixed query and method syntax
In C# you can mix query and method syntax.
```csharp
// Using a query expression with method syntax
int numCount1 = (
    from num in numbers1
    where num < 3 || num > 7
    select num
).Count();

// Better: Create a new variable to store the method call result
IEnumerable<int> numbersQuery =
    from num in numbers1
    where num < 3 || num > 7
    select num;

int numCount2 = numbersQuery.Count();
```
**Question**: Why is `numbersQuery` better?


# Student In Class Exercise - MEthod Syntax
See exercise [here](https://github.com/tgunness/ProgrammingInDotnet/blob/main/Exercises/Week%203/LINQMethodSyntaxExercise.md)

# Best Practices
- "In general, the rule is to use (Query expressions) whenever possible, and use (Method expressions) and (Mixed query and method expressions) whenever necessary." [ref](https://learn.microsoft.com/en-us/dotnet/csharp/linq/write-linq-queries#composability-of-queries)
- Prefer deferred execution, as it can lead to performance improvements (you would evaluate data only when its needed)
- Use the `.Where()` clauses to filter out unnecessary data early in the query
- If you only require certain field, use `.Select()` to project only the necessary fields, instead of returning the entire object.
- Use `Any()` instead of `Count()` when checking if a collection has at least one element.
- Use `All()` to check if all elements in a collection meet a specific condition, instead of using `Where()` and `Count()`
- Avoid Multiple Enumerations
    ```csharp
    // Multiple enumerations of a LINQ query can lead to performance issues, as the query is executed multiple times

    // Multiple enumerations (less efficient)
    IEnumerable<MyClass> results = myCollection.Where(x => x.IsValid);
    int count = results.Count(); //this evaluate the query
    foreach (var item in results) { /* ... */ } //this also evaluate the query

    // Materializing the results once (more efficient)
    List<MyClass> results = myCollection.Where(x => x.IsValid).ToList(); //the .ToList() evaluate query once
    int count = results.Count; //we don't eval query, just work with data at list
    foreach (var item in results) { /* ... */ }
    
    ```


# Weekly Exercise - Academic Records Processing Exercise
See exercise [here](https://github.com/tgunness/ProgrammingInDotnet/blob/main/Exercises/Week%203/LINQWeeklyExercise.md)


# Final Notes

- Assignment 1 (Lab 1) - you aren't allowed to use LINQ to do the sorting algorithm, must code this yourself (can't use LINQ `order by emp descending` or `order by emp ascending`)

- **Assignment 1 (Lab 1) due Sunday Sept 24th 2023 11:59pm**
    

