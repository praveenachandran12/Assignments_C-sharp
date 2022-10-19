using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class markpercent
    {

        static void Main(string[] args)
        {
            int r, total, m1, m2, m3,ma;
            string name;
            double  s, p;
            Console.WriteLine(" enter the roll no");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the name of the student");
            name=Console.ReadLine();
            Console.WriteLine(" enter maximum mark");
            ma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the 3 subject mark");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
                        p = total /3.0;
            Console.WriteLine(" Total mark of "  +name+   "   is "  +total);
            Console.WriteLine(" percentage of  " + name + "   is: " + p+"%");
            Console.ReadLine();

        }
    }
}
