using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_16_03_21
{
    class SpecialSavings : Account
    {
        public SpecialSavings() { }
        public SpecialSavings(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= (Balance * 20) / 100) 
            {
                Balance -= amount;
                Console.WriteLine("Your Special Savings account is debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= (Balance * 20) / 100)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("You account is debited by {0} to acc: {1} ({2})", amount, a.AccName, a.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

    }
}