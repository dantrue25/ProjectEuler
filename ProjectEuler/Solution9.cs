using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Solution9 : Solution
    {
        public BigInteger run()
        {
            long a = 1;
            long b = 2;
            long c = 1000 - (a + b);
            int count = 0;

            for (a = 1; a < c; a++)
            {
                for (b = a + 1; b < c; b++)
                {
                    count++;
                    c = 1000 - (a + b);
                    if ((a * a + b * b) == (c * c))
                    {
                        Console.WriteLine("Count: " + count);
                        return a * b * c;
                    }
                }

            }

            return 0;
        }
    }
}
