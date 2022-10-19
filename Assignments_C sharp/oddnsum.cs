using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class oddnsum
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("enter the  number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd natural numbers  are :  ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + "\t");
                    sum = sum + i;
                }



            }
            Console.WriteLine(" \n sum is  " + sum);
            Console.ReadLine();
        }
    }
}
