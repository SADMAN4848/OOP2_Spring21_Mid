using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_21_03_21
{
    public class Account
    {
        private string accName;
        private string acid;
        private int balance;
        Transaction[] listOfTransaction;
        private int totalNumberOfTransaction = 0;
        public Account()
        {
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public void deposit(int amount)
        {
            balance += amount;
            listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Self Deposit");
            Console.WriteLine("You have deposited BDT " + amount);
        }
        public void withdraw(int amount)
        {
            if (balance >= amount + 500)
            {
                balance -= amount;

                listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Self withdraw");
                Console.WriteLine("You have withdrawn BDT " + amount);
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        public void Transfer(Account a, int amount)
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
        void addTransaction(Transaction transaction)
        {
            listOfTransaction[totalNumberOfTransaction++] = transaction;
        }

        public void ShowAccInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + acid);
            Console.WriteLine("Acc Balance: " + balance);

        }

        public void showAllTranscation()
        {
            for(int i=0;i< totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].ShowAccInfo();
            }
        }

    }
}
