using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    class Solution10 : Solution
    {
        private const int MAX = 2000000;
        public BigInteger run()
        {
            long sum = 0;
            List<int> primesUnder2Mill = MathFunctions.PrimesListUnder(MAX);

            foreach (int prime in primesUnder2Mill)
            {
                sum += prime;
            }

            return sum;
        }
    }
}
