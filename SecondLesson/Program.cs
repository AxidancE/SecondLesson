using System;

namespace secondLesson
{
    class Program
    {
        static void Main ()
        {
            int x = 5;
            bool trueConst = true;
            bool falseConst = false;

            if (x == 5 || x !=6)
            {
                Console.WriteLine(trueConst);
            }
            else if (x != 5) 
            {
                Console.WriteLine(falseConst);
            }

            Console.WriteLine("----------");

            Console.WriteLine("Enter name: ");
            string role = Console.ReadLine();
            if(role == "Admin")
            {
                Console.WriteLine("Enter User name: ");
                string userName = Console.ReadLine();
                Console.WriteLine($"Enter {userName} age: ");
                short age = Convert.ToInt16(Console.ReadLine());

                if (age <= 0 || age > 99)
                {
                    Console.WriteLine("Error. Wrong age!");
                    Console.WriteLine($"Enter {userName} real age: ");
                    age = Convert.ToInt16(Console.ReadLine());
                }

                if (age <= 0 || age > 99)
                {
                    Console.WriteLine("Error. Wrong age!");
                    age = 1;
                } else
                {
                    Console.WriteLine($"User's age: {age}");
                }
            }
            else
            {
                Console.WriteLine("Non admino.");
            }
        }
    }
}