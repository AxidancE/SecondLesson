using System;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            //byte number = 255;
            //short number = 32767;
            //int number = 123;
            //long number = 3000000000001111111;
            //float number = 33.1f;
            //double number_2 = 32.1d;

            string word = "Hello world";
            char symbol = 'a';

            bool InQuery= false;

            Console.WriteLine (word);

            int num_1 = 0, num_2 = 0, total = 0;

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());
            
            total = num_1 + num_2;
            Console.WriteLine("Sum: " + total);
        }
    }
}