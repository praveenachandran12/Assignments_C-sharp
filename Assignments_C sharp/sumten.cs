using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class sumten
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("sum of first ten natural numbers are");
            for(i=1;i<=10;i++)
            {
                Console.Write( i);
                
                sum = sum + i;
                Console.Write("    ");
            }
            Console.WriteLine(" sum is  " + sum);
            Console.ReadLine();
        }
    }
}
