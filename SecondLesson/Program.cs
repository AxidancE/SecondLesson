using SecondLesson;
using System;

namespace Prime
{
    class Program
    {
        static void Main() 
        {
            Robot bot = new Robot("Bob", 800, new byte[] { 10, 10, 10 });
            bot.printValues();

            Killer killer = new Killer("Killah", 1000, new byte[] { 0, 0, 0 }, 100);
            killer.Laser();
            //killer.printValues();

            Robot bot1 = new Robot("Bot1");
            bot1.Weight = -100;
            Console.WriteLine(bot1.Weight);

            Robot.Print();
        }
    }
}