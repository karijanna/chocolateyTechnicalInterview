using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] array = new string[] { "madam", "step on no pets", "book" };
            foreach (string str in array)
            {
                Console.WriteLine($"{str} is {CheckPalindrome.chkPalindrome(str)}.");
            }

            Console.WriteLine("\n");

            int[] array2 = new int[] { 20, 15, 3, 6, 2, 17 };
            foreach (int i in array2)
            {
                Console.WriteLine($"{i} is {FindPrimeNumber.FindPrime(i)}.");
            }

            Console.WriteLine("\n");

            string myStr = "Welcome to Chocolatey corner";
            string myStr2 = "This is a sample string";
            Console.WriteLine(ReverseWordsInString.ReverseWordOrder(myStr));
            Console.WriteLine(ReverseWordsInString.ReverseWordOrder(myStr2));
        }
    }
}
