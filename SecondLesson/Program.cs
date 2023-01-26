using System;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            short userInput = Convert.ToInt16 (Console.ReadLine ());

            switch (userInput)
            {
                case 5: Console.WriteLine("Num is 5");
                    break;
                case 6: Console.WriteLine("Num is 6");
                    break;
                default: Console.WriteLine("I cant read number.");
                    break;
            }
        }
    }
}