using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    public class Q18
    {
        public static void solution()
        {
            Console.WriteLine("Enter two string to check anagram");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine("{0},{1}",str1,str2);
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }
}