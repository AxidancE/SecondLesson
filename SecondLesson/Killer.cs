using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    class Killer : Robot
    {
        public Killer() { }

        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates)
        {
            this.Health = health;
        }

        public override void printValues()
        {
            base.printValues();

            Console.WriteLine($"Health:{ this.Health }");
        }

        public int Health { get; set; }

        public void Laser()
        {
            Console.WriteLine("Laser has shooted.");
            base.surname = "Doe";
        }
    }
}
