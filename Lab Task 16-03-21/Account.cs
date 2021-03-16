using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_16_03_21
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        abstract public void Withdraw(double amount);

        
        abstract public void Transfer(Account a, double amount)
        {

        }


    }
}