using System;

namespace StadiumSeating
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            const decimal ClassATicketPrice = 15.00m;
            const decimal ClassBTicketPrice = 12.00m;
            const decimal ClassCTicketPrice = 9.00m;

            int classATicketsSold;
            int classBTicketsSold;
            int classCTicketsSold;

            decimal classAIncome;
            decimal classBIncome;
            decimal classCIncome;
            decimal totalIncomeGenerated;

            string input = ""; // Temporary holder of user input

            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program calculates the total revenue");
            Console.WriteLine("generated from the sale of ticket from");
            Console.WriteLine("a soccer game. There are three classes of");
            Console.WriteLine("ticket. Enter the number of tickets sold");
            Console.WriteLine("from each class.");
            Console.WriteLine("------------------------------------------");

            // Receiving number of Class A Tickes sold from user
            Console.Write("Class A Tickets: ");
            input = Console.ReadLine();
            classATicketsSold = Convert.ToInt32(input);

            // Receiving number of Class B Tickes sold from user
            Console.Write("Class B Tickets: ");
            input = Console.ReadLine();
            classBTicketsSold = Convert.ToInt32(input);

            // Receiving number of Class C Tickes sold from user
            Console.Write("Class C Tickets: ");
            input = Console.ReadLine();
            classCTicketsSold = Convert.ToInt32(input);

            //Calculating the income from each class of ticket
            classAIncome = (classATicketsSold * ClassATicketPrice);
            classBIncome = (classBTicketsSold * ClassBTicketPrice);
            classCIncome = (classCTicketsSold * ClassCTicketPrice);

            //Calculating the total income generated from all ticks
            totalIncomeGenerated = (classAIncome + classBIncome + classCIncome);


            //Calculating Miles Per Gallon

            //Outputting result to user
            Console.WriteLine("\nTotal Income Generated: $" + totalIncomeGenerated);

            Console.WriteLine("");
            Console.WriteLine("Thank You!");

            Console.ReadLine();
        }
    }
}
