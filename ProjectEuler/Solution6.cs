using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Solution6 : Solution
    {
        public BigInteger run()
        {
            return (squareOfSum(100) - sumOfSquares(100));
        }

        private BigInteger sumOfSquares (int num)
        {
            BigInteger sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        private BigInteger squareOfSum(int num)
        {
            BigInteger sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            return sum * sum;
        }
    }
}
