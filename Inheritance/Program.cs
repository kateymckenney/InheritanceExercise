using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Bird();
            bird.BeakType = "sharp";
            bird.CanFly = false;
            bird.doMigrate = false;
            bird.Color = "black and white";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var tortoise = new Reptile();
            tortoise.CanSwim = false;
            tortoise.IsScaly = false;
            tortoise.Habitat = "deserts, grasslands, and forests";
            tortoise.IsAGoodPet = true;

            var myAnimals = new Animal[] { bird, tortoise };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"This animal lays eggs: {animal.LaysEggs}");
                Console.WriteLine($"It's age in years is {animal.Age}.");
                Console.WriteLine($"It has {animal.LegCount} legs.");
                Console.WriteLine($"This animal travels by {animal.LandSeaAir}.");
                Console.WriteLine();
            }

        }

    }
}
