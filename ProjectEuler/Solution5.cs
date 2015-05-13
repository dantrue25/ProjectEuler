using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution5 : Solution
    {
        int max = 20, product = 1;

        public int run()
        {
            List<int> neededFactors = new List<int>();
            for (int i = 2; i < max; i++)
            {
                List<int> primeFactorsForCurrent = MathFunctions.primeFactors(i);
                foreach (int neededFactor in neededFactors)
                {
                    primeFactorsForCurrent.Remove(neededFactor);
                }
                foreach (int currentFactor in primeFactorsForCurrent)
                {
                    product *= currentFactor;
                    neededFactors.Add(currentFactor);
                }
            }

            return product;
        }
    }
}
