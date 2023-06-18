using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Program
    {
        public static void Main()
        {
            string InputStr = Console.ReadLine();
            string ReversedStr = ReverseString(InputStr);
            Console.WriteLine(ReversedStr);
            Console.ReadKey();
        }
        private static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            return reversedstring;
        }
    }
}
