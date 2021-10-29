using System;
using System.Collections.Generic;

namespace AverageValueCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Inputhelper.GetNumbers();
            Console.Clear();

            double average = Average.Calculate(numbers.ToArray());
            double median = Median.Calculate(numbers.ToArray());
            Console.WriteLine("Der Durchschnitt von " + string.Join(", ", numbers)  + " beträgt: "+ average);
            Console.WriteLine("Der Median von " + string.Join(", ", numbers)  + " beträgt: "+ median);
        }
    }
}