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

        private const decimal _MinimumBalance = 15m;

        //Properties
        public string AccountName { get { return _name; } }
        public string AccountNumber { get { return _number; } }
        public decimal AccountBalance { get { return _balance; } }
        public string PinCode { get { return _pin; } }

        public decimal AvailableBalance
        {
            get
            {
                return (AccountBalance - _MinimumBalance);
            }
        }

        //Constructor
               
        public BankAccount(
            string name, string pin, decimal initialDeposit)
        {
            var rand = new Random();
            
            if(initialDeposit < 15)
            {
                throw new Exception("Account cannot be opened with a balance less than "
                    + _MinimumBalance.ToString("C"));
            }

            _name = name;
            _number = rand.Next(10000, 99999).ToString();
            _pin = pin;
            _balance = initialDeposit;
        }

        //MethodsMethods
        public decimal Deposit(decimal amount)
        {
            _balance += amount;
            return _balance;
        }

        public decimal Withdraw(decimal amount)
        {
            _balance -= amount;
            return _balance;
        }
    }
}
