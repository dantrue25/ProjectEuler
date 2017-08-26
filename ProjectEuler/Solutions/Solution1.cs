using System.Numerics;

namespace ProjectEuler
{
    class Solution1 : Solution
    {
        private const int MAX = 1000;
        private const int FACTOR_1 = 3, FACTOR_2 = 5;

        public BigInteger run()
        {
            int total = 0;
            const int FACTOR_3 = FACTOR_1 * FACTOR_2;

            for (int i = 0; i < MAX; i++)
            {
                if (i % FACTOR_3 == 0)
                    total += i;
                else if (i % FACTOR_1 == 0)
                    total += i;
                else if (i % FACTOR_2 == 0)
                    total += i;
            }
            return total;
        }
    }
}
