﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class stneganoarry
    {

        public static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* Copy elements of first array into second array.*/
            for (i = 0; i < n; i++)
            {
                if (arr1[i] < 0)
                {
                    arr2[i] = arr1[i];
                }
            }

            /* Prints the elements of first array   */
            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* Prints the elements copied into the second array. */
            Console.Write("\n\nThe  negative elements copied into the second array are :\n");
            for (i = 1; i < n; i++)
            {
                Console.Write( arr2[i]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
