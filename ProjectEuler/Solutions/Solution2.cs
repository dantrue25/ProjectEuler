using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Solution2 : Solution
    {
        List<int> fiboList = new List<int> { 1, 2 };
        int totalEvens = 2;
        int lastIndex = 1;
        int lastFibo = 2;
        int max = 4000000;

        public BigInteger run()
        {
            while (lastFibo < max)
            {
                lastFibo = fiboList.ElementAt(lastIndex) + fiboList.ElementAt(lastIndex - 1);
                
                if (lastFibo % 2 == 0)
                    totalEvens += lastFibo;

                fiboList.Add(lastFibo);
                lastIndex = fiboList.IndexOf(lastFibo);
            }

            return totalEvens;
        }
    }
}
