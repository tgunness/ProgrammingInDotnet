using System;

namespace Week4InClassDemo.Finalizer
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int AgeMultipler(this Person p, int multipler)
        {
            return p.age * multipler;
        }
    }
}
