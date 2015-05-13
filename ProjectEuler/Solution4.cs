using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Solution4 : Solution
    {
        /*
         * Integers to represent the digits of the 5 and 6-digit numbers.
         * Initially the numbers are 10001 and 100001.
         */
        int firstLast = 1, secondSecondLast = 0, middleMiddles = 0;
        int largestPalin = 0;
        int fiveDig, sixDig;

        public int run()
        {
            // Make all possible 5 and 6-digit pallindrones. Then test if they are factors of two 3-digit numbers
            for (firstLast = 1; firstLast < 10; firstLast++)
            {
                for (secondSecondLast = 0; secondSecondLast < 10; secondSecondLast++)
                {
                    for (middleMiddles = 0; middleMiddles < 10; middleMiddles++)
                    {
                        sixDig = convertTo6DigitNum();
                        fiveDig = convertTo5DigitNum();

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

        // Check to see if num is a multiple of two 3-digit numbers
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
