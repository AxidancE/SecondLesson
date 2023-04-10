using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    internal class Robot
    {
        // Поля это переменные в классе?

        private static int count;

        private string name;
        
        private int weight;

        private byte[] coordinates;

        public Robot(string _name, int _weight, byte[] _coorditanes)
        {
            Console.WriteLine("Obj has been created.");
            setValues(_name, _weight, _coorditanes);
            count++;
        }

        public Robot() {
            count++;
        }

        public void setValues(string _name, int _weight, byte[] _coorditanes)
        {
            name = _name;
            weight = _weight;
            coordinates = _coorditanes;
        }

        public void printValues()
        {
            Console.WriteLine($"{name}, weight: {weight}. Coordinates:");
            foreach (var el in coordinates) Console.WriteLine(el);
        }

        public static void Print()
        { 
            Console.WriteLine($"Count is: {count}");
        }
    }
}
