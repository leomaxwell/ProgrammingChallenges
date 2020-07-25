using System;
using System.IO;

namespace SalesBarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            const int asteriskValue = 100;
            decimal store1Sale = 0;
            decimal store2Sale = 0;
            decimal store3Sale = 0;

            int store1HundredsCount;
            int store2HundredsCount;
            int store3HundredsCount;

            string input = ""; // Temporary holder of user input

            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program display a bar graph comparing");
            Console.WriteLine("the sales of three stores, using an");
            Console.WriteLine("asterisks for every $100");
            Console.WriteLine("------------------------------------------");

            // Receiving today's sale for store 1 from user
            Console.Write("Enter today's sale for Store 1: ");
            input = Console.ReadLine();
            store1Sale = Convert.ToInt32(input);

            // Receiving today's sale for store 2 from user
            Console.Write("Enter today's sale for Store 2: ");
            input = Console.ReadLine();
            store2Sale = Convert.ToInt32(input);

            // Receiving today's sale for store 3 from user
            Console.Write("Enter today's sale for Store 3: ");
            input = Console.ReadLine();
            store3Sale = Convert.ToInt32(input);

            //Calculating the income from each class of ticket
            store1HundredsCount = (int)Math.Round(store1Sale / asteriskValue);
            store2HundredsCount = (int)Math.Round(store2Sale / asteriskValue);
            store3HundredsCount = (int)Math.Round(store3Sale / asteriskValue);

            

            //Displaying bar graph for each store
            Console.WriteLine("\n\nSale Bar Graph");
            Console.WriteLine("-------------------------");
            //Store 1
            Console.Write("Store 1: ");
            for(int counter = 0; counter < store1HundredsCount; counter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
            //Store 2
            Console.Write("Store 2: ");
            int whileCounter = 0;
            while(whileCounter < store2HundredsCount)
            {
                Console.Write("*");
                whileCounter = whileCounter + 1;
            }
            Console.WriteLine();


            //Store 3
            Console.Write("Store 3: ");
            for (int counter = 0; counter < store3HundredsCount; counter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("\nThank You!");

            Console.ReadLine();
        }
    }
}
