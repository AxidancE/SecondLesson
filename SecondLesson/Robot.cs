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

        private string name;
        
        private int weight;

        private byte[] coordinates;

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
    }
}
