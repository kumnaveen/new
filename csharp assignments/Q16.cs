using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q16
    {
        public static void solution()
        {
            string str;
            int l = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}\n\n", l);
        }
    }

}
