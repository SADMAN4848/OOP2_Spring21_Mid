using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_16_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SpecialSavings("Sadman Rahman", "789463", 50000);
            Account a2 = new SpecialSavings("Navid Kaiser", "789464", 50000);
            Account a3 = new Overdraft("Ezaz Tehasy", "789465", 60000);

            Person p = new Person("Sadman Rahman");

             p.AddAccount(a1, a2, a3);
             p.ShowAccontDetails();

             var acc = p.GetAccount("789463");

             a1.Withdraw(30000);
             a3.Withdraw(64000);
            p.ShowAccontDetails();
        }
    }
}