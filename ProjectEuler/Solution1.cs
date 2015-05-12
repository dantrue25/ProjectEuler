using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjectEuler
{
    class Solution1 : Solution
    {
        int max = 1000;
        int factor1 = 3, factor2 = 5;

        public int run()
        {
            int total = 0;
            int factor3 = factor1 * factor2;

            for (int i = 0; i < max; i++)
            {
                if (i % factor3 == 0)
                    total += i;
                else if (i % factor1 == 0)
                    total += i;
                else if (i % factor2 == 0)
                    total += i;
            }
            return total;
        }
    }
}
