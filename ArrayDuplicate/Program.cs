using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 4, 4, 5, 5, 6, 6, 6, 6 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                        break;
                }
                if (counter > 1)
                {
                    Console.WriteLine(arr[i] + " occurs " + counter);
                    i += (counter - 1);
                }
            }
        }
    }
}

    
  