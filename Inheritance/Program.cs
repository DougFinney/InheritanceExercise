using System;
using System.Drawing;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal..._DONE
            // give this class 4 members that all Animals have in common..._DONE


            // Create a class Bird..._DONE
            // give this class 4 members that are specific to Bird...._DONE
            // Set this class to inherit from your Animal Class..._DONE

            // Create a class Reptile....DONE
            // give this class 4 members that are specific to Reptile...._DONE
            // Set this class to inherit from your Animal Class..._DONE

            var crow = new Bird()
            {
                Name = "Crow",
                CanFly = true,
                BuildsNest = true,
                CanSing = true,
            };

            /*Create an object of your Bird class
            *  give values to your members using the object of your Bird class
             *  
            * Creatively display the class member values 
            */

            /*Create an object of your Reptile class
            *  give values to your members using the object of your Reptile class
            *  
            * Creatively display the class member values 
            */

            var snake = new Reptile()
            {
                Name = "Rattlesnake",
                HasForkedTongue = true,
                Movement = "slithers",
                Legs = 0
            };

            Console.WriteLine();
            crow.PrintDetails();
            snake.Printdetails();

            var penguin = new Bird() 
            { 
                Name = "Penguin",
                CanFly = false,
                BuildsNest = false, 
                CanSing = false
            };

            var lizard = new Reptile() 
            {
                Name = "Lizard",
                HasForkedTongue= true, 
                Movement = "crawl", 
                Legs= 4 
            };
            
            Console.WriteLine();
            penguin.PrintDetails();
            lizard.Printdetails();
           
        }
    
    }

}

