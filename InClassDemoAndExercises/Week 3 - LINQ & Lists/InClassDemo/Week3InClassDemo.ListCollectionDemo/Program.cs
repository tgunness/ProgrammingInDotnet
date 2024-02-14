


using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        List<int> data = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

        List<int> uniqueValues = GetUniqueElements(data);

        foreach (int uniqueValue in uniqueValues)
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
        List<int> ret = new List<int>();
        foreach(int i in numbers)
        {
            if (!ret.Contains(i))
            {
                ret.Add(i);
            }
        }
        return ret;
    }



    public static List<int> GetUniqueElements_WithLINQMethod(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }

    public static List<int> GetUniqueElements_WithLINQQuery(List<int> numbers)
    {
        IEnumerable<int> query =
            (from num in numbers
            select num).Distinct();

        return query.ToList();
    }




}