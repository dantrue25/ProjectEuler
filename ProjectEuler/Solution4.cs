using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution4 : Solution
    {
        int firstLast = 1, secondSecondLast = 0, middleMiddles = 0;
        int largestPalin = 100001;

        public int run()
        {
            for (firstLast = 1; firstLast < 10; firstLast++)
            {
                for (secondSecondLast = 0; secondSecondLast < 10; secondSecondLast++)
                {
                    for (middleMiddles = 0; middleMiddles < 10; middleMiddles++)
                    {
                        int sixDig = convertTo6DigitNum();
                        int fiveDig = convertTo5DigitNum();

                        if (has3DigitFactor(sixDig))
                            largestPalin = sixDig;
                        else if (largestPalin < 100000 && has3DigitFactor(fiveDig))
                            largestPalin = fiveDig;

                    }
                }
            }
            return largestPalin;
        }

        private int convertTo6DigitNum()
        {
            int total = 0;

            total += 100001 * firstLast + 10010 * secondSecondLast + 1100 * middleMiddles;

            return total;
        }

        private int convertTo5DigitNum()
        {
            int total = 0;

            total += 10001 * firstLast + 1010 * secondSecondLast + 100 * middleMiddles;

            return total;
        }

        private bool has3DigitFactor(int num)
        {
            bool hasFactor = false;
            for(int i = 100; i < 1000; i++)
            {
                if (num % i == 0 && num/i > 100 && num/i < 1000)
                    hasFactor = true;
            }

            return hasFactor;
        }
    }
}
