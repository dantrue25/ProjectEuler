using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Solution14 : Solution
    {
        private Dictionary<long, int> numToChain;
        private const int MAX = 1000000;
        public BigInteger run1()
        {
            long largestChain = 0;
            long numWithLargestChain = 0;
            long num;
            numToChain = new Dictionary<long, int>();

            for (int i = 2; i <= MAX; i++)
            {
                int count = 0;
                num = i;
                while (num != 1)
                {
                    if (num % 2 == 0)
                        num /= 2;
                    else
                        num = num * 3 + 1;
                    count++;
                    if (numToChain.ContainsKey(num))
                    {
                        count += numToChain[num];
                        num = 1;
                    }
                    if (count > largestChain)
                    {
                        largestChain = count;
                        numWithLargestChain = i;
                    }
                }
                numToChain.Add(i, count);
            }

            return numWithLargestChain;
        }

        // Solution found on ProjectEuler forum
        public BigInteger run()
        {
            return Calculate(MAX);
        }

        public int Calculate(int limit)
        {
            var sequence = new int[limit];
            sequence[1] = 1;
            var max = 0;
            var maxIndex = 1;

            for (var i = 2; i < limit; i++)
            {
                long index = i;
                var chain = 0;
                while (true)
                {
                    if (index < i)
                    {
                        chain += sequence[index];
                        break;
                    }

                    //Optimization for: index = index % 2 == 0 ? index / 2 : 3 * index + 1
                    index = (index & 1) == 0 ? index >> 1 : index + (index << 1) + 1;

                    chain++;
                }
                sequence[i] = chain;

                if (chain > max)
                {
                    max = chain;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
