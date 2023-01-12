using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
     
        public Reptile()
        {
            BreathesAir = true;
            Legs = 4;
            HasTail = true;
            CanSwim = false;
        }
        public bool IsColdBlooded { get; set; } = true;
        public string Movement { get; set; }
        public bool HasScales { get; set; } = true;
        public bool HasForkedTongue { get; set; }

        public void Printdetails() 
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"IsColdBlooded: {IsColdBlooded}");
            Console.WriteLine($"Movement: {Movement}");
            Console.WriteLine($"HasScales: {HasScales}");
            Console.WriteLine($"HasForkedTongue: {HasForkedTongue}");

        }
    }
}
