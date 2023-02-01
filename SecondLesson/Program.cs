using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {

            //firstFunc(34);

            //int newNum = 10;

            //firstFunc(newNum);

            //Console.WriteLine(sumMe(5, 5));

            //int myNums = sumMe(1, 1);

            //firstFunc(myNums.ToString());

            byte[] nums = { 1, 2, 3, 4, 5 };

            firstFunc(SumMeToo(nums).ToString());
        }

        public static void firstFunc(string paramNew)
        {
            Console.WriteLine($"{paramNew}");
        }

        public static int sumMe(int first, int second)
        {
            int mySum = first + second;

            return mySum;
        }

        public static byte SumMeToo(byte[] arr)
        {
            byte finSum = 0;
            foreach (byte b in arr)
            {
                finSum += b;
            }

            return finSum;
        }
    }
}