﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    // Utility class to share useful functions between Solutions
    class MathFunctions
    {
        // Return a list of prime numbers up to the maximum number
        public static List<int> PrimesListUnder(int max)
        {
            List<int> primes = new List<int> { 2 };
            bool isPrime = true;

            // Check all numbers from 3 to max to possibly add to primes list
            for (int i = 3; i <= max; i++)
            {
                /*
                 * For all primes currently in 'primes' that are less than the sqrt
                 * of the current number, check if current number is divisible 
                 * by any prime. If it is, break out of the loop and check the next
                 * number. If it was divisible by a prime, then the current number
                 * is not prime. If it reached the sqrt of the current number and
                 * wasn't divisible by any of the primes before it, it is prime. 
                 */
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (primes[j] > (int)Math.Sqrt(i))
                        break;
                }
                
                if (isPrime)
                    primes.Add(i);
                isPrime = true;
            }

            return primes;
        }

        // Horribly slow at the moment, but is a Sieve-type solution
        public static List<int> GetPrimesList2(int max)
        {
            List<int> primes = new List<int>();
            int current = 2;
            int currentIndex = 0;

            for (int i = 2; i <= max; i++)
            {
                primes.Add(i);
            }

            while (currentIndex < primes.Count)
            {
                Console.WriteLine(currentIndex);


                current = primes[currentIndex];
                if (current > Math.Sqrt(max))
                    break;
                int curIndexMult = currentIndex;
                int multiple = primes[currentIndex];
                int rem = multiple * current;
                
                // Remove multiples of the current number
                while (rem <= max)
                {
                    primes.Remove(rem);
                    curIndexMult++;
                    multiple = primes[curIndexMult];
                    rem = multiple * current;
                }
                currentIndex++;
            }

            return primes;
        }

        // Return a list of primes with a size of the given number
        public static List<int> PrimesListOfSize(int size)
        {
            List<int> primes = new List<int> { 2 };
            bool isPrime = true;
            int i = 3;

            // Keep getting primes until the list has 'size' number of members
            while (primes.Count < size)
            {
                /*
                 * For all primes currently in 'primes' that are less than the sqrt
                 * of the current number, check if current number is divisible 
                 * by any prime. If it is, break out of the loop and check the next
                 * number. If it was divisible by a prime, then the current number
                 * is not prime. If it reached the sqrt of the current number and
                 * wasn't divisible by any of the primes before it, it is prime. 
                 */
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (primes[j] > (int)Math.Sqrt(i))
                        break;
                }

                if (isPrime)
                    primes.Add(i);
                isPrime = true;
                i++;
            }

            return primes;
        }

        // Return the prime factorization of an integer
        public static List<int> PrimeFactors(int num)
        {
            List<int> primes = MathFunctions.PrimesListUnder(num);
            List<int> factors = new List<int>();
            while (num != 1)
            {
                foreach (int prime in primes)
                {
                    if (num % prime == 0)
                    {
                        num /= prime;
                        factors.Add(prime);
                        break;
                    }
                    else
                    {
                        primes.Remove(prime);
                        break;
                    }
                }
            }

            return factors;
        }

        public static List<int> GetFactors(int num)
        {
            HashSet<int> factors = new HashSet<int> { 1, num };
            int upperLimit = (int)Math.Sqrt(num) + 1;

            for (int i = 2; i < upperLimit; i++)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                    factors.Add(num / i);
                }
            }

            return factors.ToList<int>();
        }

        public static List<List<long>> PascalTriangle(int maxRow)
        {
            List<long> previousRow = new List<long> { 1 };
            List<List<long>> pascalTriangle = new List<List<long>> { previousRow };
            Console.WriteLine("previousRow count = " + previousRow.Count + " element = " + previousRow[0]);

            for (int i = 1; i < maxRow; i++)
            {
                List<long> nextRow = new List<long>();
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                        nextRow.Add(previousRow[0]);
                    else
                        nextRow.Add(previousRow[j - 1] + previousRow[j]);
                    
                    if (j + 1 == previousRow.Count)
                        nextRow.Add(previousRow[j]);
                }
                pascalTriangle.Add(nextRow);
                previousRow = nextRow;
            }

            return pascalTriangle;
        }
    }
}
