using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Solutions
{
    class Solution17 : Solution
    {
        public BigInteger run()
        {
            var runningTotal = 0;
            for (var index = 1; index <= 1000; index++)
            {
                var hasTheWordAndInIt = false;
                var cur = index;
                var thousands = cur / 1000;
                cur %= 1000;
                var hundreds = (cur / 100) * 100;
                cur %= 100;
                var tens = (cur / 10) * 10;
                var ones = cur % 10;
                
                if (index == 1000)
                {
                    runningTotal += _integerToWordLengthDictionary[1000];
                    //_allIntegerToWordLength.Add(index, _integerToWordLengthDictionary[1000]);
                    break;
                }

                if (index > 100 && tens + ones > 0)
                {
                    hasTheWordAndInIt = true;
                }

                if (tens < 20)
                {
                    ones += tens;
                    tens = 0;
                }

                //_allIntegerToWordLength.Add(index,
                //    _integerToWordLengthDictionary[hundreds / 100] + (hundreds > 0 ? _integerToWordLengthDictionary[100] : 0) +
                //    _integerToWordLengthDictionary[tens] +
                //    _integerToWordLengthDictionary[ones] +
                //    (hasTheWordAndInIt ? "and".Length : 0));
                runningTotal += _integerToWordLengthDictionary[hundreds / 100] + (hundreds > 0 ? _integerToWordLengthDictionary[100] : 0) +
                    _integerToWordLengthDictionary[tens] +
                    _integerToWordLengthDictionary[ones] +
                    (hasTheWordAndInIt ? "and".Length : 0);
            }

            return runningTotal;
        }

        private IDictionary<int, int> _integerToWordLengthDictionary = new Dictionary<int, int>
        {
            { 0, 0 },
            { 1, "one".Length },
            { 2, "two".Length },
            { 3, "three".Length },
            { 4, "four".Length },
            { 5, "five".Length },
            { 6, "six".Length },
            { 7, "seven".Length },
            { 8, "eight".Length },
            { 9, "nine".Length },
            { 10, "ten".Length },
            { 11, "eleven".Length },
            { 12, "twelve".Length },
            { 13, "thirteen".Length },
            { 14, "fourteen".Length },
            { 15, "fifteen".Length },
            { 16, "sixteen".Length },
            { 17, "seventeen".Length },
            { 18, "eighteen".Length },
            { 19, "nineteen".Length },
            { 20, "twenty".Length },
            { 30, "thirty".Length },
            { 40, "forty".Length },
            { 50, "fifty".Length },
            { 60, "sixty".Length },
            { 70, "seventy".Length },
            { 80, "eighty".Length },
            { 90, "ninety".Length },
            { 100, "hundred".Length },
            { 1000, "onethousand".Length }
        };

        //private IDictionary<int, int> _allIntegerToWordLength = new Dictionary<int, int>();
    }
}
