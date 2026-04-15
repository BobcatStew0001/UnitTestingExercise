using System;
using System.Runtime.InteropServices;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3,5,10, 18)]
        [InlineData(4,4,4,12)]
        [InlineData(5,5,5,15)]
        [InlineData(100,200,700,1000)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator(); 


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = Calculator.Add(num1, num2, num3);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(15, 10, 5)]
        [InlineData(100, 25, 75 )]
        [InlineData(1000, 550, 450 )]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = Calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 10)]//Add test data <-------
        [InlineData(3,5,15)]
        [InlineData(4,5,20)]
        [InlineData(10,2,20)]
        [InlineData(10,10,100)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(6,2,3)]
        [InlineData(20,2,10)]
        [InlineData(30,3,10)]
        
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
