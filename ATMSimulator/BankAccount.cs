using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public class BankAccount
    {
        //Fields
        private string _name;
        private string _number;
        private string _pin;
        private decimal _balance;

        private const decimal minimumBalance = 15m;


        //Properties
        public string AccountName { get { return _name; } }
        public string AccountNumber { get { return _number; } }
        public decimal AccountBalance { get { return _balance; } }
        public string PinCode { get { return _pin; } }

        //Constructor
        public BankAccount(
            string name, string pin, decimal initialDeposit)
        {
            var rand = new Random();
            
            if(initialDeposit < 15)
            {
                throw new Exception("Account cannot be opened with a balance less than "
                    + minimumBalance.ToString("C"));
            }

            _name = name;
            _number = rand.Next(10000, 99999).ToString();
            _pin = pin;
            _balance = initialDeposit;
        }

        //MethodsMethods
        public bool Authenticate(string pin)
        {
            return true;
        }
        public decimal Deposit(decimal amount)
        {
            return 0m;
        }
        public decimal Withdraw(decimal amount)
        {
            return 0m;
        }
    }
}
