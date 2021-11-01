using System;
using System.Linq;

namespace AverageValueCalculator
{
    public static class Median
    {
        public static double Calculate(double[] numbers)
        {
            if (numbers.Length == 0) return 0;

            double[] sortedNumbers = numbers;
            Array.Sort(sortedNumbers);

            int mid = numbers.Length / 2;
            var isEven = numbers.Length % 2 == 0;
            if (isEven)
            {
                int firstIndex = mid - 1;
                double firstNumber = numbers.ElementAt(firstIndex);
                double secondNumber = numbers.ElementAt(firstIndex + 1);

                return (firstNumber + secondNumber) / 2;
            }


            return numbers.ElementAt(mid);
        }
    }
}