using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            short[] nums = { 5, 6, 7, 8, 5, 3, 4 };

            short[,] secnums = {
                {
                    1, 2, 3,
                },
                {
                    1, 2, 3
                }
            };

            foreach (short elem in secnums)
            {
                Console.WriteLine($"Element: {elem}");
            }

            List<int> numbers = new List<int>()
            {
                1, 2, 3
            };


            numbers.Add(440);
            numbers.Add(5);
            numbers.Add(144);

            //numbers.Remove(644);
            numbers.Sort();
            numbers.Reverse();
            numbers.Clear();

            foreach(int elem in numbers)
            {
                Console.WriteLine($"Element is: {elem}");
            }
        }
    }
}