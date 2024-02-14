using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Week3InClassDemo.Common;

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

            //Highest
            int highestValue = 0;
            for(int i = 0; i<data.Length; i++)
            {
                if (data[i] > highestValue)
                    highestValue = data[i];
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



            //Objects - Get by name
            Student[] students = new Classroom().Students;
            Student[] results = new Student[students.Length];
            count = 0;
            foreach(Student student in students)
            {
                if(student.FirstName.StartsWith("J"))
                {
                    results[count] = student;
                    count++;
                }
            }

            foreach(Student student in results)
            {
                Console.WriteLine(student);
            }


            Console.ReadKey();
        }
    }
}
