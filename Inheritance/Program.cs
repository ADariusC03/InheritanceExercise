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


            Birds hedwig = new Birds()
            {
                Name = "Hedwig",
                Age = 29,
                Legs = 2,
                HasClaws = true,
                HasBeak = true,
                Wings = 2,
                Species = "Snowy owl",
                IsWarmBlooded = true,
            };

            Console.WriteLine($" {hedwig.Name} is an {hedwig.Species} female that has" +
                $" {hedwig.Wings} snowy white wings, {hedwig.Legs} black legs, and is also {hedwig.Age} years old");
            Console.WriteLine();
            Console.WriteLine($" Does {hedwig.Name} habe claws, a sharp beak, and warm blooded?" +
                $" {hedwig.HasClaws}, {hedwig.HasBeak}, {hedwig.IsWarmBlooded}");
            Console.WriteLine();





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            Reptile hydra = new Reptile()
            {
                Name = "Hydra",
                Age = 1100,
                Legs = 4,
                HasClaws = true,
                Heads = 6,
                Environment = "Lake of Lerna",
                Type = "Water",
                IsColdBlooded = true,
            };

            Console.WriteLine($" {hydra.Name} is {hydra.Age} years old with {hydra.Heads} heads and {hydra.Legs} legs." +
                $" Lives in {hydra.Environment} as a gigantic {hydra.Type} serpent.");
            Console.WriteLine();
            Console.WriteLine($"Is {hydra.Name} cold blooded and has claws? {hydra.HasClaws}, {hydra.IsColdBlooded}");
            Console.WriteLine();




        }
    }
}
