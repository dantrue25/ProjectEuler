using System.Linq;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution16 : Solution
    {
        public BigInteger run()
        {
            var powerArray = new int[500];
            powerArray[0] = 2;
            var numberOfDigits = 1;

            for (int exponent = 2; exponent <= 1000; exponent++)
            {
                var carryTheOne = false;
                for (int i = 0; i < numberOfDigits; i++)
                {
                    powerArray[i] *= 2;

                    if (carryTheOne)
                    {
                        powerArray[i]++;
                    }

                    carryTheOne = false;

                    if (powerArray[i] > 9)
                    {
                        powerArray[i] -= 10;
                        carryTheOne = true;
                    }
                }
                if(carryTheOne)
                {
                    powerArray[numberOfDigits]++;
                    numberOfDigits++;
                }
            }
            
            return powerArray.Sum();
        }
    }
}
