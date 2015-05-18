using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution15 : Solution
    {
        private const int DIMENSION = 20;
        public BigInteger run()
        {
            int depth = 2 * DIMENSION + 1;
            List<List<long>> pascal = MathFunctions.pascalTriangle(depth);

            return pascal[depth - 1][DIMENSION];
        }
    }
}
