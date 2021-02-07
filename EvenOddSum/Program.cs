using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int oddSum = 0;


            for (int num = 0; num < 100; num++)
            {
                if (num % 2 == 0)
                {
                    evenSum = evenSum + num;
                }
                else
                {
                    oddSum = oddSum + num;
                }
            }
            Console.WriteLine("Sum of even numbers : " + evenSum); 
            Console.WriteLine("Sum of all odd numbers : " + oddSum);
        }
    }
}
