using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q3
    {
        public static void solution()
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}",a,b);
            if(a<b)
            {
                for(int i=a;i<b;i++)
                {
                       int c;
                       c=a++;
                       Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
