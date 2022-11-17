using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q15
    {
        public static void solution()
        {
                int i, n, sum = 0;
                double avg;

                Console.Write("\n\n");
                Console.Write("Read 10 marks and calculate total and average:\n");
                Console.Write("\n\n");

                Console.Write("Input the 10 numbers : \n");
                for (i=1; i<=10; i++)
                {
                    Console.Write("Number-{0} :", i);

                    n= Convert.ToInt32(Console.ReadLine());
                    sum +=n;
                }
                avg=sum/10.0;
                Console.Write("The sum of 10 marks is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
    }
