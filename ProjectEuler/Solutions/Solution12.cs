using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution12 : Solution
    {
        private const int MAX_FACTORS = 500;

        public BigInteger run()
        {
            List<int> factors = MathFunctions.GetFactors(28);
            int num = 2;

            while (MathFunctions.GetFactors((num * (num + 1)) / 2).Count < MAX_FACTORS)
                num++;

            return (num * (num + 1)) / 2;
        }
    }
}
