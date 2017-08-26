using System.Collections.Generic;

namespace ProjectEuler
{
    class Solution7 : Solution
    {
        public System.Numerics.BigInteger run()
        {
            List<int> primes = MathFunctions.PrimesListOfSize(10001);
            int prime10001 = primes[primes.Count - 1];

            return prime10001;
        }
    }
}
