using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    internal class Q9
    {
        public static void solution()
        {
            
                int n1 = 0, n2 = 1, n3, i;

                Console.Write("Enter the number of elements: ");

                Console.Write(n1+" "+n2+" ");

            for (i=2; i<10; ++i)
            {
                    n3=n1+n2;
                if (n3<40)
                {
                    Console.Write(n3+" ");
                    n1=n2;
                    n2=n3;
                }
                else { break; }
  
            }
        }
    }
}
