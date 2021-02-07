﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account{ 
    
        string accName;
        string acid;
        int balance;
    
    public Account()
    {
    }
    public Account(string accName,string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance= balance;
        }
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("You have deposited BDT " + amount);
        }
        public void withdraw(double amount)
        {
            if (balance >= amount + 500)
            {
                balance -= amount;
                Console.WriteLine("You have withdrawn BDT " + amount);
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }


