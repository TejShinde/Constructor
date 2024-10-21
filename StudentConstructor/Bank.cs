using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConstructor
{
    internal class Bank
    {
        private double balance;
        public Bank(double initialBal)
        {
            balance = initialBal;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited:" +amount);
        }

        public void withdraw(double amount)
        {
            if (amount <= balance)  
            {
                balance -= amount;  
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance! Withdrawal failed.");
            }
        }

        public void DisplayBal()
        {
            Console.WriteLine("Current Balance:" + balance);
        }
    }
}
