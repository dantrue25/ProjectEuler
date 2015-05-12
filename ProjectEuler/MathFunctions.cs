using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // Utility class to share useful functions between Solutions
    class MathFunctions
    {
        // Return a list of prime numbers up to the maximum number
        public static List<int> getPrimesList(int max)
        {
            List<int> primes = new List<int> { 2 };
            bool isPrime = true;

            // Check all numbers from 3 to max to possibly add to primes list
            for (int i = 3; i < max; i++)
            {
                /*
                 * For all primes currently in 'primes' that are less than the sqrt
                 * of the current number, check if current number is divisible 
                 * by any prime. If it is, break out of the loop and check the next
                 * number. If it was divisible by a prime, then the current number
                 * is not prime. If it reached the sqrt of the current number and
                 * wasn't divisible by any of the primes before it, it is prime. 
                 */
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

        // Horribly slow at the moment, but is a Sieve-type solution
        public static List<int> getPrimesList2(int max)
        {
            List<int> primes = new List<int>();
            int current = 2;
            int currentIndex = 0;

            for (int i = 2; i <= max; i++)
            {
                primes.Add(i);
            }

            while (currentIndex < primes.Count)
            {
                Console.WriteLine(currentIndex);


                current = primes[currentIndex];
                if (current > Math.Sqrt(max))
                    break;
                int curIndexMult = currentIndex;
                int multiple = primes[currentIndex];
                int rem = multiple * current;
                
                // Remove multiples of the current number
                while (rem <= max)
                {
                    primes.Remove(rem);
                    curIndexMult++;
                    multiple = primes[curIndexMult];
                    rem = multiple * current;
                }
                currentIndex++;
            }

            return primes;
        }
    }
}
