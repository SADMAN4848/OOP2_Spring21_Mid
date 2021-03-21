using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_21_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Sadman", "22345", 500);
            Account a2 = new Account("Sakib", "22346", 250);
            Transaction t1 = new Transaction(a1,a2,200, "Credited");
        }
    }
}
