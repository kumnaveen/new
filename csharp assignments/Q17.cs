using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q17
    {
        public static void solution()
        {
            string myStr, rev;
            Console.WriteLine("Enter string to reverse");
            myStr = Console.ReadLine();
            rev ="";
            Console.WriteLine("String is {0}", myStr);
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
            Console.ReadLine();
        }
    }
}