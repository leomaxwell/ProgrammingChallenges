using System;

namespace StockTransactionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            int totalSharesPurchased = 100;
            decimal purchasePricePerShare = 32.87m;
            decimal salePricePerShare = 33.92m;
            decimal brokerRate = (2.00m / 100.00m);


            decimal stockPurchaseAmount;
            decimal commissionOnPurchase;
            decimal stockSaleAmount;
            decimal commissionOnSale;
            decimal netEarningsOnTrade;

            //Processing
            stockPurchaseAmount = (totalSharesPurchased * purchasePricePerShare);
            commissionOnPurchase = (stockPurchaseAmount * brokerRate);
            stockSaleAmount = (totalSharesPurchased * salePricePerShare);
            commissionOnSale = (stockSaleAmount * brokerRate);
            netEarningsOnTrade = stockSaleAmount - (stockPurchaseAmount + commissionOnPurchase + commissionOnSale);


            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This program calculates and provides");
            Console.WriteLine("the Net Transaction Earnings on stocks");
            Console.WriteLine("traded by Joe in June, 2020.");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Stock Purchase Amount: \t" + stockPurchaseAmount.ToString("C").PadLeft(9, ' '));
            Console.WriteLine("Commission on Purchase: " + commissionOnPurchase.ToString("C").PadLeft(9, ' '));
            Console.WriteLine("Stock Sale Earnings: \t" + stockSaleAmount.ToString("C").PadLeft(9, ' '));
            Console.WriteLine("Commission on Sale: \t" + commissionOnSale.ToString("C").PadLeft(9, ' '));

            Console.WriteLine("\nNET EARNINGS ON TRADE: \t" + netEarningsOnTrade.ToString("C").PadLeft(9, ' '));

            Console.WriteLine("");
            Console.WriteLine("Thank You!");

            Console.ReadLine();
        }
    }
}
