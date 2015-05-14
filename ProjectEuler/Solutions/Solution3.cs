using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution3 : Solution
    {
        long bigNum = 600851475143;
        int maxPrime = 1;

        public BigInteger run()
        {
            int maxPossible = (int)Math.Sqrt(bigNum) + 1;
            List<int> primes = MathFunctions.primesListUnder(maxPossible);

            // Check primes list to find largest prime that is a factor of bigNum
            for (int i = 0; i < primes.Count; i++)
            {
                if (bigNum % primes[i] == 0)
                    maxPrime = primes[i];
            }

            return maxPrime;
        }
    }
}
