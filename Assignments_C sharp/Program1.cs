using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a, sum = 0, r;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                r = a % 10;
                sum = sum + r;
                a = a / 10;
            }
            Console.WriteLine("sum   is  " + sum);
            Console.ReadLine();
        }
    }
}
