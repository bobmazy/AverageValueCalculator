using System;
using System.Collections.Generic;
using System.Globalization;

namespace AverageValueCalculator
{
    public static class Inputhelper
    {
        public static List<double> GetNumbers()
        {
            Boolean abort = false;
            List<double> numbers = new List<double>();
            do
            {
                Console.WriteLine("Aktuelle Zahlen: " + string.Join("; ", numbers));
                Console.WriteLine("Geben Sie B für Berechnen oder E für eine weitere Eingabe einer Zahl.");
                ConsoleKeyInfo nextStep = Console.ReadKey();
                EmptyLine();
                if (ConsoleKey.B.Equals(nextStep.Key))
                {
                    abort = true;
                }
                else if(ConsoleKey.E.Equals(nextStep.Key))
                {
                    double newNumber = GetInputInt();
                    numbers.Add(newNumber);
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie B für Berechnen oder E für eine weiter Eingabe der Zahl ein.");
                }

            } while (!abort);

            return numbers;
        }

        private static double GetInputInt(int rangeStart = Int32.MinValue, int rangeEnd = Int32.MaxValue)
        {
            bool validInput;
            double input = 0;
            do
            {
                try
                {
                    string stringInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(stringInput))
                    {
                        validInput = false;
                        EmptyLine();
                        Console.WriteLine("Bitte geben Sie etwas ein");
                    }
                    else
                    {
                        validInput = Double.TryParse(stringInput, NumberStyles.Any, CultureInfo.InvariantCulture, out input);
                        if (!validInput)
                        {
                            EmptyLine();
                            Console.WriteLine("Bitte geben Sie eine gültige Zahl ein");
                        }

                        bool inputOutOfRange = rangeStart > input || input > rangeEnd;
                        if (inputOutOfRange)
                        {
                            validInput = false;
                            EmptyLine();
                            Console.WriteLine(
                                $"Die Zahl {input} liegt nicht im gültigen Zahlenbereich von {rangeStart} bis {rangeEnd}");
                        }
                    }
                }
                catch (Exception e)
                {
                    validInput = false;
                    EmptyLine();
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein");
                }
            } while (!validInput);

            return input;
        }

        private static void EmptyLine()
        {
            Console.WriteLine();
        }
    }
}