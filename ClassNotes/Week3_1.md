# Week 3 - LINQ and List Collection

# Week 3 Part 1 - Introduction to LINQ
## Agenda
- Overview
- Architecture
- Query Syntax
- Method Syntax
- Best Practices
## Overview
- LINQ stands for Language Integrated Query 
- It's a set of features in C# for querying and manipulating data
- It allows to write queries directly in code (you can even write SQL like code)
    - query = set of instructions that describe what data to retrieve from a given data source
- LINQ operates on data sources:
    - LINQ to Objects - query in-memory collections likes arrays, lists and dictionaries
    - LINQ to SQL - query and manipulate data in relational database
    - LINQ to XML - simplifies XML processing
- Has flexibility, providing you with two ways of writing queries
    - Query Syntax
    - Method Syntax

## Architecture
- LINQ supports data types that inherit from IEnumerable (`T` is a placeholder for any data type; a generic)
    -  Types that support IEnumerable<T> or a derived interface such as the generic IQueryable<T> are called _queryable types_.
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
### Deferred Execution
- The query variable itself only stores the query commands. The actual execution of the query is deferred until you iterate over the query variable in a foreach statement.
- Because the query variable itself never holds the query results, you can execute it as often as you like.
    - This becomes very relevant in LINQ to SQL where you want to query for the latest data at various stages. 
- You can force immediate execution by specifying an extension method (ie. `.Max()`, `.Count()`, etc)
## Query Syntax (aka Query Expression)
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
- Query Expressions
    ```csharp
    // Data source.
    int[] scores = { 90, 71, 82, 93, 75, 82 };

    // Query Expression.
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

## Method Syntax

- Introduction to Collections (35mins)
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
    





- "The following examples demonstrate some simple LINQ queries by using each approach listed previously. In general, the rule is to use (Query syntax) whenever possible, and use (Method syntax) and (Mixed query and method syntax) whenever necessary." [ref](https://learn.microsoft.com/en-us/dotnet/csharp/linq/write-linq-queries#composability-of-queries)

