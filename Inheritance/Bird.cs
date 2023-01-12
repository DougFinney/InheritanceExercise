using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {


        public Bird()
        {
            BreathesAir = true;
            Legs = 2;
            HasTail = true;
            CanSwim = false;
        }
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set; }
        public bool BuildsNest { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Has Feathers: {HasFeathers}");
            Console.WriteLine($"Can Sing: {CanSing}");
            Console.WriteLine($"Build Nest: {BuildsNest}");
        }
        
        
    }
}
