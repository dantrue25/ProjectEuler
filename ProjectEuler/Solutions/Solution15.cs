using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution15 : Solution
    {
        private const int DIMENSION = 20;
        public BigInteger run()
        {
            int depth = 2 * DIMENSION + 1;
            List<List<long>> pascal = MathFunctions.PascalTriangle(depth);

            return pascal[depth - 1][DIMENSION];
        }
    }
}
