using BlakeIshoyAlgorithms.Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlakeIshoyAlgorithms.MathAlgorithms
{
    public static class MathTools
    {
        public static int FibonacciLoopSumEvens(int ceiling)
        {
            var evenTotal = 0;
            var previousNumber = 1;
            var currentNumber = 2;
            var holder = currentNumber;

            while (currentNumber < ceiling)
            {
                if (currentNumber % 2 == 0)
                {
                    evenTotal += currentNumber;
                }
                currentNumber += previousNumber;
                previousNumber = holder;
                holder = currentNumber;
            }
            return evenTotal;
        }

        public static long LargestPrimeFactor(long number)
        {
            var result = new long();
            var rootOfNumber = Math.Floor(Math.Sqrt(number));
            for (int i = 3; i < rootOfNumber; i++)
            {
                if (!(number / i % 1 == 0))
                {
                    
                }
            }
            return result;
        }

        public static int RecursiveFactorial(int number, int counter)
        {
            counter--;
            if (counter == 1)
            {
                return number;
            }
            return RecursiveFactorial(number * counter, counter);
        }

        public static int LoopedFactorial(int number)
        {
            var counter = number;
            while (counter > 1)
            {
                counter--;
                number *= counter;
            }
            return number;
        }

        public static int PermutationCalc(int n, int r)
        {
            var calc = n - r;
            if (calc == 0) { calc = 1; }
            return LoopedFactorial(n) / LoopedFactorial(calc);
        }

        public static int EuclidGreatestCommonDenominator(int A, int B)
        {
            
            if (A != 0 && B != 0)
            {
                var remainder = A % B;
                return EuclidGreatestCommonDenominator(B, remainder);
            }
            else
            {
                return A;
            }
        }
    }
}
