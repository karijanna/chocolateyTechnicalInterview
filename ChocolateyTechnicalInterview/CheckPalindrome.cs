using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    public class CheckPalindrome
    {
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
    }
}

//reference: https://www.dotnetperls.com/palindrome
