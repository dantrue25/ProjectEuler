using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution3 : Solution
    {
        long bigNum = 600851475143;
        int maxPrime = 1;

        public int run()
        {
            int maxPossible = (int)Math.Sqrt(bigNum) + 1;
            List<int> primes = MathFunctions.getPrimesList(maxPossible);

            for (int i = 0; i < primes.Count; i++)
            {
                if (bigNum % primes[i] == 0)
                    maxPrime = primes[i];
            }

            return maxPrime;
        }
    }
}
