using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class star1
    {
        static void Main(string[] args)
        {
            int numberoflayer , Space, Number;
            Console.WriteLine("Print paramid");
            Console.WriteLine("enter the no of rows");
            numberoflayer = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numberoflayer; i++)  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)   
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++)  
                    Console.Write('*');
                for (Number = (i - 1); Number >= 1; Number--) 
                    Console.Write('*');
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
