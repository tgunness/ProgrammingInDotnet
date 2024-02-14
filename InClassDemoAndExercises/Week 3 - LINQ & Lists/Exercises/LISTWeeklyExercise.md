# `List<T>` Weekly Exercise

Given the below code please added the required `using ` libraries and complete the code of the `GetUniqueElements` method.

Please refer to the C# List<T> Collection spec [here](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0#methods)

```csharp
//TODO: add all required using statements

public class Program
{
    static void Main(string[] args)
    {
        List<int> data = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

        List<int> uniqueValues = GetUniqueElements(data);

        foreach(int uniqueValue in uniqueValues)
        {
            Console.WriteLine($"{uniqueValue} is a unique number in data");
        }
        Console.ReadLine();
    }

    /// <summary>
    /// This method uses List collection to get all unique values within the input parameter
    /// A unique value is a number that does not repeat, or appear more than once in collection
    /// </summary>
    public static List<int> GetUniqueElements(List<int> numbers)
    {
        //TODO: add code here to return a List<int> of all integers that are unique in numbers
    }

}
