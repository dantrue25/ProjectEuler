using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution7 : Solution
    {
        public System.Numerics.BigInteger run()
        {
            List<int> primes = MathFunctions.primesListOfSize(10001);
            int prime10001 = primes[primes.Count - 1];

            return prime10001;
        }
    }
}
