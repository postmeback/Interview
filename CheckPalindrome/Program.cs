using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    public class Program
    {
        public static void Main()
        {
            string InputStr = Console.ReadLine();
            string ReversedStr = chkPalindrome(InputStr);
            Console.WriteLine(ReversedStr);
            Console.ReadKey();
        }
        internal static string chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {

                    flag = true;
                }

            }
            if (flag)
            {
                return "Palindrome";
                //Console.WriteLine("Palindrome");
            }
            else
            {
                return "Not Palindrome";
            }

        }
    }
}
