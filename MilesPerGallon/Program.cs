using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            double maxGallons = 0;
            double fullTankMiles = 0;
            double milesPerGallon = 0;

            string input = "";

            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program calculates a car's gas");
            Console.WriteLine("mileage based on the number of");
            Console.WriteLine("gallons the car can hold (Maximum Gallons)");
            Console.WriteLine("and number of miles it can be driven on");
            Console.WriteLine("full tank. (Miles on full tank).");
            Console.WriteLine("------------------------------------------");

            // Receiving maxGallons from user
            Console.Write("Enter Maximum Gallons: ");
            input = Console.ReadLine();            
            maxGallons = Convert.ToDouble(input); //Converting input to double

            // Receiving fullTankMiles from user
            Console.Write("Enter Miles on Full Tank: ");
            input = Console.ReadLine();
            fullTankMiles = Convert.ToDouble(input);

            //Calculating Miles Per Gallon
            milesPerGallon = (fullTankMiles / maxGallons);

            //Outputting result to user
            Console.WriteLine("Your car Gas Mileage: " + milesPerGallon + "mpg");
            
            Console.WriteLine("");
            Console.WriteLine("Thank You!");

            Console.ReadLine();
        }
    }
}
