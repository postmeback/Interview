
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
            char[] chars = str.ToCharArray();
            int length = str.Length;

            for (int i = 0, j = length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }

            string reversedString = new string(chars);

            return reversedString;
        }
    }
}
