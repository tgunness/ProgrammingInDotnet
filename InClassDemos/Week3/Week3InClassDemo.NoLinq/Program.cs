using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Week3InClassDemo.NoLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] data = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };

            foreach (int i in data)
            {
                Console.WriteLine(i);
            }

            //Greater Than
            int[] greaterThanFive = new int[10];
            int count = 0;
            for(int i = 0; i< data.Length; i++)
            {
                if (data[i] > 5)
                    greaterThanFive[count] = data[i];
            }

            //Less Than
            int[] lessThanFive = new int[10];
            count = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 5)
                    lessThanFive[count] = data[i];
            }

            //Highest
            int highestValue = 0;
            for(int i = 0; i<data.Length; i++)
            {
                if (data[i] > highestValue)
                    highestValue = data[i];
            }

            //Lowest
            int lowestValue = 10;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < lowestValue)
                    lowestValue = data[i];
            }

            //Sorted Ascending
            int[] sortedAscending = data;
            int temp;
            for (int i = 0; i <= sortedAscending.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedAscending.Length; j++)
                {
                    if (sortedAscending[i] > sortedAscending[j])
                    {
                        temp = sortedAscending[i];
                        sortedAscending[i] = sortedAscending[j];
                        sortedAscending[j] = temp;
                    }
                }
            }

            //Sorted Descending
            int[] sortedDescending = data;
            temp = 0;
            for (int i = 0; i <= sortedDescending.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedDescending.Length; j++)
                {
                    if (sortedDescending[i] < sortedDescending[j])
                    {
                        temp = sortedDescending[i];
                        sortedDescending[i] = sortedDescending[j];
                        sortedDescending[j] = temp;
                    }
                }
            }

            //Objects - Get by name
            Person[] persons = new Person[]
            {
                new Person(1, "john doe", "55 acme road"),
                new Person(2, "jason borne", "40 b road"),
                new Person(50, "jane parker", "20 a road")
            };


            Person[] persons2 = new Person[3];
            count = 0;
            foreach(Person p in persons2)
            {
                if(p.Name.Contains("john"))
                {
                    persons2[count] = p;
                    count++;
                }
            }


            Console.ReadKey();
        }
    }
}
