using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class eqlintegers
    {
        static void Main(string[] args)
        {

            int a,b;
            Console.WriteLine(" enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter  another number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else 
            {
                Console.WriteLine(" Two numbers are  not equal ");
            }
            
            Console.ReadLine();
        }


    }
}
