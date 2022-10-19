using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class Program2
    {
        static void Main(string[] args)
        {
            int j,k;
            Console.WriteLine(" enter a number");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" multiplication table of   " +k+ " is ");
            for(j=1;j<=10;j++)
            {
                Console.WriteLine("{1} X {0} = {2} \n", k, j, j * k);
            }
            Console.ReadLine();
        }
    }
}
