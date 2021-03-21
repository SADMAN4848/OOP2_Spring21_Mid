using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport
{
    class GradeReport
    {
        static void Main(string[] args)
        {
            int Physics = 88;
            int Chemistry = 78;
            int Biology = 75;
            int Mathematics = 86;
            int Computer = 92;

            int average = (Physics + Chemistry + Biology + Mathematics + Computer) / 5;


        if (average>50 && average < 75){
                Console.Write("Grade C+");
            }
        if (average > 75 && average < 79)
            {
                Console.Write("Grade B");
            }
        if (average > 80 && average < 85)
            {
                Console.Write("Grade B+");
            }
        if (average > 85 && average < 89)
            {
                Console.Write("Grade A");
            }
            if (average >90)
            {
                Console.Write("Grade A");
            }
        }
    }
}
