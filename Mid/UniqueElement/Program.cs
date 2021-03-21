using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, count=0;
            int[] arr = new int[] { 1, 2, 3,3, 4, 4, 4, 5,6, 6, 6, 6 };

            Console.WriteLine("Unique elements on this array are : ");

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0;j< arr.Length; j++)
                {
                    if(i!=j)
                    {
                        if (arr[i] != arr[j])
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if(flag==1)
                {
                    count++;
                    Console.WriteLine(arr[i] + " ");
                }
            }



        }
    }
}
