using System;

namespace MarkUp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wholesaleCost;
            decimal markupPercentage;
            decimal retailPrice;

            string input = ""; // Temporary holder of user input

            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program calculates the retail price");
            Console.WriteLine("of an item given its wholesale cost");
            Console.WriteLine("and markup percentage.");
            Console.WriteLine("------------------------------------------");

            Console.Write("Wholesale Cost: ");
            input = Console.ReadLine();
            wholesaleCost = Convert.ToDecimal(input);

            Console.Write("Markup Percentage: ");
            input = Console.ReadLine();
            markupPercentage = Convert.ToDecimal(input);

            retailPrice = CalculateRetailPrice(wholesaleCost, markupPercentage);

            //Outputting result to user
            Console.WriteLine("\nRetail Price: $" + retailPrice);

            Console.WriteLine("");
            Console.WriteLine("Thank You!");

            Console.ReadLine();

        }

        /// <summary>
        /// This method calculates the retail price given the cost and markup percent.
        /// </summary>
        /// <param name="cost">The wholesale cost of the item.</param>
        /// <param name="percent">The intended markup percent.</param>
        /// <returns>The retails price of the item.</returns>
        public static decimal CalculateRetailPrice(decimal cost, decimal percent)
        {
            decimal markup = (percent / 100);

            decimal retailPrice = cost + (cost * markup);

            return retailPrice;
        }
    }
}
