using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingquestions
{
    class novowelsstring
    {
        static void Main(string[] args)
        {

            string str;
            int i, len, vowel;
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();

            vowel = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                
            }
            Console.WriteLine("\nThe total number of vowel in the string is : {0}\n", vowel);
            Console.ReadLine();
        }
    }
}
