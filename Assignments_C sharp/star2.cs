using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class star2
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of rows:\t");
            int rows = int.Parse(Console.ReadLine());
            int i, j, k = 0;
            for (i = rows; i >= 1; i--)
            {
                for (j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
