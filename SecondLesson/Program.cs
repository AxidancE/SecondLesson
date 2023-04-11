using SecondLesson;
using System;
using System.Collections.Generic;

namespace Prime
{
    class Program
    {
        static void Main() 
        {
            //Robot bot = new Robot("Bob", 800, new byte[] { 10, 10, 10 });
            //bot.printValues();

            Killer killer = new Killer("Killah", 1000, new byte[] { 0, 0, 0 }, 100);
            killer.Laser();
            killer.printValues();

            //Robot bot1 = new Robot("Bot1");
            //bot1.Weight = -100;
            //Console.WriteLine(bot1.Weight);

            //Robot.Print();

            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Alex", 400, new byte[] { 10, 0, 0 }, 100));
            robots.Add(new Killer("Bob", 600, new byte[] { 20, 70, 90 }, 200));
            robots.Add(new Killer("John", 800, new byte[] { 30, 80, 20 }, 300));
            robots.Add(new Killer("Josh", 900, new byte[] { 40, 90, 30 }, 400));

            Robot newRobot = null;

            foreach (Robot obj in robots)
            {
                if(obj.Name == "John")
                {
                    newRobot = obj as Robot;
                }

                int num = 0;
                Console.WriteLine(obj is Killer);
            }
        }
    }
}