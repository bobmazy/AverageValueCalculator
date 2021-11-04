using System;
using AverageValueCalculator.AverageValuVariants;
using NUnit.Framework;

namespace Test
{
    public class AverageTest
    {
        [Test]
        [TestCase(TestName = "/TAF1/")]
        public void Calculate_with_one_number()
        {
            // Arrange
            double[] numbers = {1.5};

            // Act
            double median = Average.Calculate(numbers);

            // Assert
            Assert.AreEqual(1.5, median);
        }

        [Test]
        [TestCase(TestName = "/TAF2/")]
        public void Calculate_with_equal_numbers()
        {
            // Arrange
            double[] numbers = {1.5, 1.5, 1.5};

            // Act
            double median = Average.Calculate(numbers);

            // Assert
            Assert.AreEqual(1.5, median);
        }

        [Test]
        [TestCase(TestName = "/TAF3/")]
        public void Calculate_with_different_numbers()
        {
            // Arrange
            double[] numbers = {3, 5, 7.5};

            // Act
            double median = Average.Calculate(numbers);


            // Assert
            Assert.AreEqual(5.166, GetDoubleWithLast3DecimalPlaces(median));
        }

        [Test]
        [TestCase(TestName = "/TAF4/")]
        public void Calculate_with_negative_numbers()
        {
            // Arrange
            double[] numbers = {-1, -5, 2, 5};

            // Act
            double median = Average.Calculate(numbers);


            // Assert
            Assert.AreEqual(0.25, median);
        }

        [Test]
        [TestCase(TestName = "/TAF5/")]
        public void Calculate_with_unsorted_numbers()
        {
            // Arrange
            // -8 -5 -1 2 5 10
            double[] numbers = {10, -1, -5, 2, 5, -8};

            // Act
            double median = Average.Calculate(numbers);


            // Assert
            Assert.AreEqual(0.5, median);
        }

        private double GetDoubleWithLast3DecimalPlaces(double number)
        {
            decimal d = (decimal) number;
            d = Math.Truncate(d * 1000m) / 1000m;
            return (double) d;
        }
    }
}