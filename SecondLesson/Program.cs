using SecondLesson;
using System;

namespace Prime
{
    class Program
    {
        static void Main() 
        {
            Robot bot = new Robot();

            bot.setValues("Bob", 800, new byte[] { 10, 10, 10 });
            bot.printValues();

            bot.setValues("Killah", 1000, new byte[] { 0, 0, 0 });
            bot.printValues();
            //bot.name = "Bob";
            //bot.weight = 800;
            //bot.coordinates = new byte[] { 10, 10, 10 };

            //Console.WriteLine($"{bot.name}, weight: {bot.weight}");

            //Robot killer = new Robot();
            //killer.weight = 1000;
            //killer.name = "Killah";
            //killer.coordinates = new byte[] { 0, 0, 0 };
        }
    }
}