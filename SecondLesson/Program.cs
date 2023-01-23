using System;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            float userInput, result;
            
            Console.Write("Input float number: ");

            //userInput = Convert.ToDouble(Console.ReadLine());
            userInput = float.Parse(Console.ReadLine());
            
            result = userInput + 10.3f;

            result *= 1.5f;
            
            //result = userInput - 10.3f;
            //result = userInput * 10.3f;
            //result = userInput / 10.3f;
            //result = userInput % 10.3f;
            
            //int a = 5, b = 10;
            //int res = a % b;

            Console.WriteLine("Result: " + result);

            Console.WriteLine("----------");

            // cw (+tab +tab) = Console.WriteLine();

            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.E);
            //Console.WriteLine(Math.Abs(-10));
            //Console.WriteLine(Math.Ceiling(10.11f)); // To higher number
            //Console.WriteLine(Math.Floor(10.11f)); // To lower number
            //Console.WriteLine(Math.Round(10.11f)); // Just round number

            //const int myInt = 1;

            Console.WriteLine("Enter radius of cirlce: ");

            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Area of circle with radius {0} equals {1}", radius, area);

        }
    }
}