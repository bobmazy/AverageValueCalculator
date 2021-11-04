namespace AverageValueCalculator.AverageValuVariants
{
    public static class Average
    {
        public static double Calculate(double[] numbers)
        {
            if (numbers.Length == 0) return 0;

            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }

            double count = numbers.Length;
            return sum / count;
        }
    }
}