using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 7, 4, 12)]
        [InlineData(1, 2, 5, 8)]
        [InlineData(1, 1, 1, 3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calc = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(3, 1, 2)]
        [InlineData(1, 1, 0)]
        [InlineData(9, 5, 4)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 5, 30)]//Add test data <-------
        [InlineData(5, 3, 15)]
        [InlineData(9, 3, 27)]
        [InlineData(1, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(13, 2, 6.5)]//Add test data <-------
        [InlineData(25, 5, 5)]
        [InlineData(60, 10, 6)]
        [InlineData(121, 11, 11)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
