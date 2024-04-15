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

            var Owl = new Bird();

            Owl.Size = "large";
            Owl.IsWoodPecker = false;
            Owl.FurFeatherScalesOrCoat = "feathers";
            Owl.HerbCarnOrOminvore = "herbivore";
            Owl.IsMammal = false;
            Owl.NumberOfLegs = 2;

            Console.WriteLine($"An Owl is a {Owl.Size} bird so it is {Owl.IsMammal} that it is a mammal. It is covered in {Owl.FurFeatherScalesOrCoat} and has {Owl.NumberOfLegs}. It is {Owl.IsWoodPecker} but it is an {Owl.HerbCarnOrOminvore}.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Iguana = new Reptile();

            Iguana.IsHerbivore = true;

            Iguana.NumberOfLegs = 4;

            Iguana.AquaticTerrestrialOrBoth = "both";

            Iguana.LaysEggs = true;

            Console.WriteLine($" Iguanas are very unique reptiles because it is {Iguana.IsHerbivore} that they are herbivores and {Iguana.AquaticTerrestrialOrBoth} aquatic and terrestrial. They have {Iguana.NumberOfLegs} and {Iguana.LaysEggs}.");
        }
    }
}
