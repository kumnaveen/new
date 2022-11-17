using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q14
    {
        public static void solution()
        {
                int i;
                int[] a = new int[30]; 
                Console.Write("Enter the Number of values to find Smallest: ");
                int n = Convert.ToInt16(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    Console.Write("Enter the No " + i + ":");
                    a[i] = Convert.ToInt16(Console.ReadLine());
                }
                for (i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                } 
                Console.WriteLine("The smallest Value is "+a[1]);  
                Console.ReadKey();
            
        }
    }
    }
