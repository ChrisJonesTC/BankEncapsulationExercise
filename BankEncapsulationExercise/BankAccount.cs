using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
            Console.WriteLine();
            Console.WriteLine($"{depositAmount,0:c} is being deposited into your checking account.");
        }

        public void Withdrawl(double withdrawlAmount)
        {
            balance -= withdrawlAmount;
            Console.WriteLine();
            Console.WriteLine($"{withdrawlAmount,0:c} is being withdrawn from your checking account.");
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
