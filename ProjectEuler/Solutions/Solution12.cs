using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution12 : Solution
    {
        private const int MAX_FACTORS = 500;

        public BigInteger run()
        {
            List<int> factors = MathFunctions.getFactors(28);
            int num = 2;

            while (MathFunctions.getFactors((num * (num + 1)) / 2).Count < MAX_FACTORS)
                num++;

            return (num * (num + 1)) / 2;
        }
    }
}
