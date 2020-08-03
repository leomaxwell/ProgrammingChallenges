using System;
using System.Collections.Generic;

namespace ATMSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations

            string pinCode;
            decimal accountBalance;
            decimal amount;
            string choice;
            string input = "";
            bool run = true;
            List<BankAccount> accounts = new List<BankAccount>();

            try
            {
                do
                {
                    DisplayTopLevelWelcomeMessage(); //Display Welcome Message

                    choice = GetUserTopLevelActionChoice(); //Get User Choice

                    //Validate user choice
                    //Ask again if choice is invalid
                    while (TopLevelChoiceIsValid(choice) == false)
                    {
                        Console.WriteLine("Choice is invalid, please try again.");
                        choice = GetUserTopLevelActionChoice(); //Get User Choice
                    }

                    if (choice == "1")
                    {
                        UseATM();
                    }
                    else if (choice == "2")
                    {
                        var bankAccount = CreateAccount();
                        accounts.Add(bankAccount);
                        Console.WriteLine("\n\nAccount successfully created...");
                        Console.WriteLine("Name: " + bankAccount.AccountName);
                        Console.WriteLine("Number: " + bankAccount.AccountNumber);
                        Console.WriteLine("Balance: " + bankAccount.AccountBalance);


                        Console.Write("\n\nDo you want to perform another action? [Y] /[N]: ");
                        input = Console.ReadLine();
                        run = (input.ToUpper() == "Y");
                    }
                    else if (choice == "3")
                    {
                        Exit();
                    }
                    //Choice is valid, move on...
                } while (run == true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                Console.ReadLine();
            }
        }

        public static void DisplayTopLevelWelcomeMessage()
        {
            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Welcome to Comax Bank International");
            Console.WriteLine("Please provide your choice of action.");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1\t Use ATM");
            Console.WriteLine("2\t Create Bank Account");
            Console.WriteLine("3\t Exit");
            Console.WriteLine("------------------------------------------");
        }

        public static string GetUserTopLevelActionChoice()
        {
            string input = "";



            // Receiving today's sale for store 1 from user
            Console.Write("Enter Choice: ");
            input = Console.ReadLine();
            return input;
        }

        public static bool TopLevelChoiceIsValid(string choice)
        {
            if (choice == "1" || choice == "2" || choice == "3")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static BankAccount CreateAccount()
        {
            try
            {
                string accountName;
                string pinCode;
                string input = "";

                decimal initialDeposit = 0m;

                // Message to the user
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("You have selected Account Creation");
                Console.WriteLine("Please provide your required information");
                Console.WriteLine("------------------------------------------");

                //Account Name
                Console.Write("Account Name: ");
                input = Console.ReadLine();
                accountName = input;

                //Initial Balance
                Console.Write("Initial Deposit: ");
                input = Console.ReadLine();
                decimal.TryParse(input, out initialDeposit);

                //Pin Code
                Console.Write("Pin Code (4-Digit): ");
                input = Console.ReadLine();
                pinCode = input;

                var account = new BankAccount(accountName, pinCode, initialDeposit);

                return account;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void UseATM()
        {
            string pinCode;
            decimal accountBalance;
            decimal amount;
            string choice;
            string input;
            bool run = true;

            BankAccount selectedAccount = null;

            do
            {
                choice = GetUserATMLevelActionChoice(); //Get User Choice

                //Validate user choice
                //Ask again if choice is invalid
                while (ATMLevelChoiceIsValid(choice) == false)
                {
                    Console.WriteLine("Choice is invalid, please try again.");
                    choice = GetUserATMLevelActionChoice(); //Get User Choice
                }
                do
                {
                    if (choice == "1")
                    {
                        // Todo: Implement Account Balance;

                    }
                    else if (choice == "2")
                    {
                        //TO DO: Implement Withdrawal
                    }
                    else if (choice == "3")
                    {
                        //TO DO: Implement Deposit
                    }
                    else if (choice == "4")
                    {
                        Exit();
                    }

                    Console.WriteLine("\n\nDo you want to perform another action? [Y] /[N]");
                    input = Console.ReadLine();
                    run = (input.ToUpper() == "Y");
                } while (selectedAccount == null);

            } while (run == true);
        }

        public static void DisplayATMWelcomeMessage()
        {
            // Message to the user
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Welcome to Comax Bank International ATM");
            Console.WriteLine("Please provide your choice of action.");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1\t Account Balance");
            Console.WriteLine("2\t Withdraw");
            Console.WriteLine("3\t Deposit");
            Console.WriteLine("4\t Exit");
            Console.WriteLine("------------------------------------------");
        }

        public static string GetUserATMLevelActionChoice()
        {
            string input = "";

            Console.Write("Enter Choice: ");
            input = Console.ReadLine();
            return input;
        }

        public static bool ATMLevelChoiceIsValid(string choice)
        {
            if (choice == "1" || choice == "2" || 
                choice == "3" || choice == "4")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("\nThank You for doing business with us!");
            Console.ReadLine();
        }
    }
}
