using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Together
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Tanvir Ahmed", "478941", 50000);
            Account a2 = new Account("Sadman Rahman", "478942", 45000);
            Account a3 = new Account("Wasi Islam", "478943", 40000);
            a1.ShowAccInfo();
            a1.deposit(500);
            a1.withdraw(300);
            a1.ShowAccInfo();


            Course b1 = new Course("Java", "102",3);
            Course b2 = new Course("CAD", "105",1);
            Course b3 = new Course("OOP2","120",3);
            b1.ShowInfo();
            b2.ShowInfo();
            b3.ShowInfo();
        }
    }
}
