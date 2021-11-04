using System;
using System.Collections.Generic;
using System.Globalization;

namespace AverageValueCalculator.Input
{
    public static class InputHelper
    {
        public static InputResult ReadNumbers()
        {
            var parsedNumbers = new List<double>();
            Console.WriteLine("Bitte Geben Sie die Zahlen ein");
            Console.WriteLine("Bitte separieren Sie die Zahle mit einen Komma.");
            Console.WriteLine("Beispiel: -1,1,2.5,8");
            EmptyLine();

            string input = Console.ReadLine();

            if (input != null && input.Trim().Length > 0)
            {
                string[] numbers = input.Trim().Split(',');
                foreach (string number in numbers)
                {
                    bool validNumber = Double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture,
                        out var parsedNumber);
                    if (validNumber)
                    {
                        parsedNumbers.Add(parsedNumber);
                    }
                    else
                    {
                        string errorMessage = $"Die Eingabe beinhaltet folgende ungültige Eingabe: {number} ." + "\n" +
                                              "Bitte geben Sie eine gültige Zahl ein.";

                        return new InputResult(parsedNumbers, false, errorMessage);
                    }
                }
            }
            else
            {
                return new InputResult(parsedNumbers, false, "Bitte geben Sie etwas ein.");
            }

            return new InputResult(parsedNumbers, true);
        }


        public static void EmptyLine()
        {
            Console.WriteLine();
        }
    }
}