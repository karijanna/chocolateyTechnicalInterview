using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    public class FindPrimeNumber
    {
        internal static bool FindPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }

            int bounds = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= bounds; i+=2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

//reference: https://stackoverflow.com/questions/1510124/program-to-find-prime-numbers
