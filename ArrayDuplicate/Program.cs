﻿using System;
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
            int[] arr = new int[] { 1, 2, 3, 4, 4,4, 5, 5};
            int[] ar = new int[100];
            int counter = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        //Console.WriteLine(arr[j]);
                        counter++;
                        
                    }
                    else break;
                }
                if (counter > 1)
                {
                    Console.WriteLine(arr[i] + " occurs " + counter);
                }
            }
        }
    }
}
