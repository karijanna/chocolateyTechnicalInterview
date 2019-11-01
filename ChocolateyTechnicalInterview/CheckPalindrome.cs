using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    class CheckPalindrome
    {
        static void Main(string[] args)
        {
            string[] array = { "madam", "step on no pets", "book"};
            foreach (string str in array)
            {
                Console.WriteLine($"{str} is {chkPalindrome(str)}.");
            }
        }

        internal static string chkPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return "Not Palindrome";
                }
            }
            return "Palindrome";
        }

        //reference: https://www.dotnetperls.com/palindrome
    }
}
