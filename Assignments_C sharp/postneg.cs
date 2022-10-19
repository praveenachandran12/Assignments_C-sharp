using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class postneg
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine(" enter a number");
             a= Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a+ " is a positive number ");
            }
            else if(a < 0)
            {
                Console.WriteLine(a + " is a negative number ");
            }
            else
            {
                Console.WriteLine( " no is Zero ");
            }
            Console.ReadLine();
        }
    }
}
