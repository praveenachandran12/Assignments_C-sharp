using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class largest3
    {
        static void Main(string[] args)
        {

            int a, b,c;
            Console.WriteLine(" enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if( a>b)
            {
                if(a>c)
                {
                    Console.WriteLine(a+ "  is grater" );
                }
                else
                {
                    Console.WriteLine( c+ "  is grater" );
                }
            }
            else
            {
                Console.WriteLine(b + "  is grater" );
            }
            Console.ReadLine();
        }
    }
}
