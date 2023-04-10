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

        public Robot(string name, int weight, byte[] coordinates)
        {
            Console.WriteLine("Obj has been created.");
            setValues(name, weight, coordinates);
            count++;
        }

        public Robot() {
            count++;
        }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void printValues()
        {
            Console.WriteLine($"{this.name}, weight: {this.weight}. Coordinates:");
            foreach (var el in this.coordinates) Console.WriteLine(el);
        }

        public static void Print()
        { 
            Console.WriteLine($"Count is: {count}");
        }
    }
}
