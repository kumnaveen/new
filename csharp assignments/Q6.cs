using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q6
    {
        public static void solution()
        {
            double fahrenheit;

            double celsius;
            Console.WriteLine("Enter celsius");
            celsius=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}