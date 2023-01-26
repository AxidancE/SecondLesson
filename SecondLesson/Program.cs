using System;
using System.Linq.Expressions;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            for (int i = 1; i < 10; i *= 2)
            {
                Console.WriteLine ($"Element: {i}");
            }

            int j = -100;
            while (j < 0)
            {
                j -= 10;
                Console.WriteLine($"Element: {j}");
            }

            bool isHasCar = true;
            string sold;
            while (isHasCar) {
                sold = Console.ReadLine ();
                switch (sold) 
                {
                    case "end":
                        isHasCar = false;
                        break;
                    default:
                        Console.WriteLine("Not sold.");
                        break;
                }
            }

            byte k = 100;
            do {
                Console.WriteLine($"Element: {k}");
                k--;
            } while (k < 10);

            for(short i = 0; i < 10; i++)
            {
                //if (i > 5) 
                //    break;
                if (i % 2 == 0)
                    continue;
                Console.WriteLine($"Element: {i}");
            }
        }
    }
}