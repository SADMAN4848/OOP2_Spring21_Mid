using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTriangle
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Triangle a1 = new Triangle(4, 4, 4);
            Triangle a2 = new Triangle(4, 4, 6);
            Triangle a3 = new Triangle(3, 4, 5);
            a1.ShowInfo();
            a1.TestTriangle();
            a2.ShowInfo();
            a2.TestTriangle();
            a3.ShowInfo();
            a3.TestTriangle();
        }
    }
}
