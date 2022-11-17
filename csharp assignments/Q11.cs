using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q11
    {
        public static void solution()
        {
            int i, n;
            Console.Write("Display the multiplication table:\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i=1; i<=20; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n*i);
            }
        }
    }
}
