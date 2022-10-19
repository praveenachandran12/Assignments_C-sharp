using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class sumofarry
    {
        public static void Main()
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\n\nFind sum of all elements of array:\n");
            Console.Write("Input the number of elements  :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" {0}th element   : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
            Console.ReadLine();
        }
    }
}
