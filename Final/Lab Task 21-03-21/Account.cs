using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_21_03_21
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int Balance { get; set; }
        Transaction[] listOfTransaction;
        public int totalNumberOfTransaction { get; set; }

        public Account()
        {

        }
        public Account(string accName, string accNo, int balance)
        {
            this.AccName = accName;
            this.AccNo = accNo;
            this.Balance = balance;
            listOfTransaction = new Transaction[10];
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("You have deposited BDT " + amount + " and new Balance " + Balance);
            listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Deposit");
        }

        public void Withdraw(int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Self withdraw");
                Console.WriteLine("You have withdrawn BDT " + amount + " and new balance " + Balance);
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }
        public void Transfer(Account a, int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                a.Balance += amount;
                listOfTransaction[totalNumberOfTransaction++] = new Transaction(this, a, amount, "Transfer");
                Console.WriteLine("You account is debited by " + amount + " to acc " + a.AccName+ a.AccNo);
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }


        public void addTransaction(Account sender, Account receiver, int amount)
        {
            foreach (Transaction transaction in listOfTransaction)
            {
                this.listOfTransaction[totalNumberOfTransaction++] = transaction;
            }
        }

        public void showAllTransaction()
        {
            Console.WriteLine("All Transactions");

            for (int i = 0; i < totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].showTransactions();
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc Number: " + AccNo);
            Console.WriteLine("Acc Balance: " + Balance);
            
        }


    }
}