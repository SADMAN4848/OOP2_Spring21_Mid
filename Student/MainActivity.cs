using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sadman Rahman","18388323", "CSE",4.00F);
            Student s2 = new Student("Khalid Labib", "18384737", "EEE", 3.70F);
            s1.ShowInfo();
            s2.ShowInfo();
        }
    }
}
