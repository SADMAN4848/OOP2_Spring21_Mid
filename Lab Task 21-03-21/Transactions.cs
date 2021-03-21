using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_21_03_21
{
    public class Transaction
    {
        Account sender;
        Account receiver;
        private int amount;
        private string additionalInfo;

        public Transaction()
        {
        }
        public Transaction(Account sender, Account receiver,int amount, string additionalInfo)
        {
            this.amount = amount;
            this.additionalInfo = additionalInfo;
        }

        public void setTransaction()
        {

        }
        public int Amount { get; set; }
        public string AdditionalInfo { get; set; }


        
    }
}
