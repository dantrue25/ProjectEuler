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
            List<int> primes = MathFunctions.getPrimesList2(maxPossible);
            //List<String> primesStr = new List<String>();

            for (int i = 0; i < primes.Count; i++)
            {
                //primesStr.Add(primes[i].ToString());
                if (bigNum % primes[i] == 0)
                    maxPrime = primes[i];
            }

            //System.IO.File.WriteAllLines(@"C:\Users\Dan\Documents\ProjectEuler\PrimesList.txt", primesStr.ToArray());
            return maxPrime;
        }
    }
}
