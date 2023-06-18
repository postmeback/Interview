using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOccurrence
{
    public class Program
    {
        public static void Main()
        {
            string InputStr = Console.ReadLine();
            Dictionary<char, int> Result = CountCharacterOccurrence(InputStr);
            Console.ReadKey();
        }
        internal static Dictionary<char, int> CountCharacterOccurrence(string str)
        {
            Dictionary<char, int> countDetails = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (countDetails.ContainsKey(c))
                {
                    countDetails[c]++;
                }
                else
                { 
                    countDetails.Add(c, 1);
                }
           }

            return countDetails;
        }
    }
}
