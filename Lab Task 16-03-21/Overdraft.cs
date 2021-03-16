﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_16_03_21
{
    class Overdraft : Account
    {
        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance >=amount || amount<=Balance+5000)
            {
                Balance -= amount;
                Console.WriteLine("Your Overdraft account is debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("You account is debited by {0} to acc: {1} ({2})", amount, a.AccName, a.AccNo);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}