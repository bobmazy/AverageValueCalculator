using System;
using AverageValueCalculator.AverageValuVariants;
using AverageValueCalculator.Input;

namespace AverageValueCalculator
{
    public static class AverageValueCalculator
    {
        public static void Program()
        {
            Console.WriteLine("--- Programm gestartet ---");
            InputHelper.EmptyLine();
            var inputResult = InputHelper.ReadNumbers();


            if (inputResult.ValidInput)
            {
                double average = Average.Calculate(inputResult.Numbers.ToArray());
                double median = Median.Calculate(inputResult.Numbers.ToArray());
                Console.WriteLine("Der Durchschnitt von " + string.Join(", ", inputResult.Numbers) + " beträgt: " + average);
                Console.WriteLine("Der Median von " + string.Join(", ", inputResult.Numbers) + " beträgt: " + median);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe, Fehlermeldung: \n" + inputResult.ErrorMessage);
            }

            InputHelper.EmptyLine();
            Console.WriteLine("--- Programm beendet ---");
        }
    }
}