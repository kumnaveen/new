using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q4
    {
        public static void solution()
        {
            Console.WriteLine("Enter number to check odd or even");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("GIVEN NUMBER Is EVEN");
            }
            else 
            {
                Console.WriteLine("\"GIVEN NUMBER Is ODD"); 
            }
        }
    }
}
