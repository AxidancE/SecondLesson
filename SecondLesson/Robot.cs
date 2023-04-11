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

        protected string surname;

        public int Weight 
        {
            get 
            {
                Console.Write("Result: ");
                return this.weight;
            }

            set
            {
                if (value < 1)
                {
                    this.weight = 1;
                }
                else if (value > 5000)
                {
                    this.Weight = 5000;
                }
                else this.weight = value;
            }
        }

        public int Width { private get; set; }

        public Robot(string name, int weight, byte[] coordinates)
        {
            Console.WriteLine("Obj has been created.");
            setValues(name, weight, coordinates);
            count++;
        }

        public Robot()
        {
            count++;
        }

        public Robot(string name) {
            this.name = name;
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
