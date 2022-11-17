using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q10
    {
        public static void solution()
        {
            {
                int i, c;
                Console.Write("\n\n");
                Console.Write("Display the cube of the number:\n");
                Console.Write("\n\n");

                Console.Write("Input number of terms : ");
                c= Convert.ToInt32(Console.ReadLine());
                for (i=1; i<=c; i++)
                {
                    Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i*i*i));
                }
            }
        }
    }

 }

