using System;
using System.Diagnostics;

namespace SoftwareSales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            const decimal RetailPrice = 99m;

            decimal discountRate = 0;
            decimal discount = 0;
            decimal subTotalCost;
            decimal totalCost;

            int unitsPurchased;

            string input = "";

            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program computes the total cost");
            Console.WriteLine("of purchase of package from a Software");
            Console.WriteLine("Company.");
            Console.WriteLine("------------------------------------------");

            // Receiving units purchase from user
            Console.Write("Enter Units Purchased: ");
            input = Console.ReadLine();
            unitsPurchased = Convert.ToInt32(input); //Converting input to int
           
            if(unitsPurchased < 10)
            {
                discountRate = 0;
            }
            else if ((unitsPurchased >= 10) && (unitsPurchased <= 29))
            {
                discountRate = (20m / 100.00m);
            }
            else if ((unitsPurchased >= 30) && (unitsPurchased <= 49))
            {
                discountRate = (30m / 100m);
            }
            else if ((unitsPurchased >= 50) && (unitsPurchased <= 99))
            {
                discountRate = (40m / 100m);
            }
            else
            {
                discountRate = (50m / 100m);
            }


            subTotalCost = unitsPurchased * RetailPrice;
            discount = subTotalCost * discountRate;
            totalCost = subTotalCost - discount;

            //Outputting result to user
            Console.WriteLine("\nQuantity: \t\t" + unitsPurchased.ToString().PadLeft(9, ' '));
            Console.WriteLine("Sub Total: \t\t" + subTotalCost.ToString("C").PadLeft(9, ' '));
            Console.WriteLine("Discount ("+ (discountRate * 100) + "%): \t" + discount.ToString("C").PadLeft(9, ' '));
            Console.WriteLine("Total Cost: \t\t" + totalCost.ToString("C").PadLeft(9, ' '));


            Console.WriteLine("");
            Console.WriteLine("Thank You!");

            Console.ReadLine();
        }
    }
}
