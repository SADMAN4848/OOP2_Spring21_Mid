using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_21_03_21
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        public int Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, int amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            AdditionalInfo = additionalInfo;
            Amount = amount;
        }

        public void showTransactions()
        {
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Receiver: " + receiver);
            Console.Write("Amount: " + Amount);
        }
    }
}