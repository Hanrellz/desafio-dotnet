using System;
using System.Collections.Generic;
using System.Linq;

namespace Mouts.Business
{
    public class Fibonacci
    {
        public static long GetValueFromIndex(int fibonacciIndex)
        {
            string[] numbers =  Calculate(fibonacciIndex).Split(',');
            int lastNumberIndex = numbers.Length - 1;

            return numbers.Any() ? long.Parse(numbers[lastNumberIndex]) : 0;
        }

        public static long GetAmount(int fibonacciIndex)
        {
            return Calculate(fibonacciIndex).Split(',').ToList().Sum(number => long.Parse(number));
        }

        public static string GetSequency(int fibonacciIndex)
        {
            return Calculate(fibonacciIndex);
        }

        private static string Calculate(int fibonacciIndex)
        {
            IList<long> numbers = new List<long>();

            long initialIndex = 0;
            long index = 1;

            for (int i = 0; i < fibonacciIndex; i++)
            {
                numbers.Add(index);

                long assistant = initialIndex;
                initialIndex = index;
                index = assistant + index;
            }

            return string.Join(",", numbers);
        }
    }
}
