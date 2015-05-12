using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class MathFunctions
    {
        public static List<int> getPrimesList(int max)
        {
            List<int> primes = new List<int> { 2 };
            bool isPrime = true;

            for (int i = 3; i < max; i++)
            {
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (primes[j] > (int)Math.Sqrt(i))
                        break;
                }
                if (isPrime)
                    primes.Add(i);
                isPrime = true;
            }

            return primes;
        }
    }
}
