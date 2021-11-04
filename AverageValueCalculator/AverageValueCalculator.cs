using System;
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
                double median = Median.Calculate(inputResult.Numbers.ToArray());
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