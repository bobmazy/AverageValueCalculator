using System.Collections.Generic;

namespace AverageValueCalculator.Input
{
    public class InputResult
    {
        public List<double> Numbers { get; }
        public bool ValidInput { get; }
        public string ErrorMessage { get; }

        public InputResult(List<double> numbers, bool validInput, string errorMessage = "")
        {
            Numbers = numbers;
            ValidInput = validInput;
            ErrorMessage = errorMessage;
        }
    }
}