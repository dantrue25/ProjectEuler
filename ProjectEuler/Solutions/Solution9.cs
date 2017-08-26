using System.Numerics;

namespace ProjectEuler
{
    class Solution9 : Solution
    {
        private const int TOTAL = 1000;

        public BigInteger run()
        {
            long a = 1;
            long b = 2;
            long c = TOTAL - (a + b);

            for (a = 1; a < c; a++)
            {
                for (b = a + 1; b < c; b++)
                {
                    c = TOTAL - (a + b);
                    if ((a * a + b * b) == (c * c))
                        return a * b * c;
                }

            }

            return 0;
        }
    }
}
