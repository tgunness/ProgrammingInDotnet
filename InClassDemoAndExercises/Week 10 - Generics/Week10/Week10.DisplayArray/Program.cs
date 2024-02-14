using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.DisplayArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            float[] floatArray = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f };

            Console.WriteLine("Array intArray contains: ");
            DisplayArray(intArray, doubleArray);
            Console.WriteLine("Array doubleArray contains: ");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains: ");
            DisplayArray(charArray);
            Console.WriteLine("Array floatArray contains: ");
            DisplayArray(floatArray);
        }

        private static void DisplayArray<T>(T[] genericArray)
        {
            foreach (var element in genericArray)
            {
                Console.WriteLine(element);
            }
        }
        private static void DisplayArray<T>(T[] genericArray, T[] array2)
        {
            foreach (var element in genericArray)
            {
                Console.WriteLine(element);
            }

            foreach (var element in array2)
            {
                Console.WriteLine(element);
            }
        }

        private static void DisplayArray<T1, T2>(T1[] genericArray, T2[] array2)
        {
            foreach (var element in genericArray)
            {
                Console.WriteLine(element);
            }

            foreach (var element in array2)
            {
                Console.WriteLine(element);
            }
        }


        //private static void DisplayArray(int[] intArray)
        //{
        //    foreach(var element in intArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        //private static void DisplayArray(double[] doubleArray)
        //{
        //    foreach (var element in doubleArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}

        //private static void DisplayArray(char[] charArray)
        //{
        //    foreach (var element in charArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
    }
}
