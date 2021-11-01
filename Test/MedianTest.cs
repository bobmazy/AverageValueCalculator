using AverageValueCalculator;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [Test]
        [TestCase(TestName = "/TAF1/")]
        public void Calculate_with_an_no_numbers()
        {
            // Arrange
            double[] numbers = { };

            // Act
            double median = Median.Calculate(numbers);

            // Assert
            Assert.AreEqual(0, median);
        }

        [Test]
        [TestCase(TestName = "/TAF2/")]
        public void Calculate_with_one_number()
        {
            // Arrange
            double[] numbers = {1};

            // Act
            double median = Median.Calculate(numbers);

            // Assert
            Assert.AreEqual(1, median);
        }

        [Test]
        [TestCase(TestName = "/TAF3/")]
        public void Calculate_with_equal_numbers()
        {
            // Arrange
            double[] numbers = {1.5, 1.5, 1.5};

            // Act
            double median = Median.Calculate(numbers);

            // Assert
            Assert.AreEqual(1.5, median);
        }

        [Test]
        [TestCase(TestName = "/TAF4/")]
        public void Calculate_with_different_numbers()
        {
            // Arrange
            double[] numbers = {2.5, 5, 7.5};

            // Act
            double median = Median.Calculate(numbers);


            // Assert
            Assert.AreEqual(5, median);
        }


        [Test]
        [TestCase(TestName = "/TAF5/")]
        public void Calculate_with_even_length_of_numbers()
        {
            // Arrange
            double[] numbers = {2.5, 5, 7, 7.5};

            // Act
            double median = Median.Calculate(numbers);


            // Assert
            Assert.AreEqual(6, median);
        }

        [Test]
        [TestCase(TestName = "/TAF6/")]
        public void Calculate_with_odd_length_of_numbers()
        {
            // Arrange
            double[] numbers = {2.5, 5, 7.5};

            // Act
            double median = Median.Calculate(numbers);


            // Assert
            Assert.AreEqual(5, median);
        }

        [Test]
        [TestCase(TestName = "/TAF7/")]
        public void Calculate_with_negative_numbers()
        {
            // Arrange
            double[] numbers = {-1, -5, 2, 5};

            // Act
            double median = Median.Calculate(numbers);


            // Assert
            Assert.AreEqual(0.5, median);
        }
    }
}