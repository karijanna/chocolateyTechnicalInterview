using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    public class FindPrimeNumber
    {
        internal static string FindPrime(int number)
        {
            if (number <= 1)
            {
                return "Not Prime";
            }
            else if (number == 2)
            {
                return "Prime";
            }
            else if (number % 2 == 0)
            {
                return "Not Prime";
            }

            int bounds = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= bounds; i+=2)
            {
                if (number % i == 0)
                {
                    return "Not Prime";
                }
            }
            return "Prime";
        }
    }
}

//reference: https://stackoverflow.com/questions/1510124/program-to-find-prime-numbers
