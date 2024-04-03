using System;
using System.IO;
using Algorithms.Simulation;
using Xunit;

namespace Algorithms.Tests.Simulation
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ExecuteExample1_ShouldReturnExpectedValue()
        {
            // Arrange
            int numberUpTo = 15;
            var expectedOutput = "12fizz4buzzfizz78fizzbuzz11fizz1314fizzbuzz";
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            FizzBuzz.ExecuteExample1(numberUpTo);
            var actualOutput = writer.ToString();

            // Assert
            Assert.Equal(
                expectedOutput,
                actualOutput.Replace("\n", "").Replace("\r", "")
            );
        }

        [Fact]
        public void ExecuteExample2_ShouldReturnExpectedValue()
        {
            // Arrange
            int numberUpTo = 15;
            var expectedOutput = "12fizz4buzzfizz78fizzbuzz11fizz1314fizzbuzz";
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            FizzBuzz.ExecuteExample2(numberUpTo);
            var actualOutput = writer.ToString();

            // Assert
            Assert.Equal(
               expectedOutput,
               actualOutput.Replace("\n", "").Replace("\r", "")
           );
        }

        [Fact]
        public void ExecuteExample3_ShouldReturnExpectedValue()
        {
            // Arrange
            int numberUpTo = 15;
            var expectedOutput = "12fizz4buzzfizz78fizzbuzz11fizz1314fizzbuzz";
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            FizzBuzz.ExecuteExample3(numberUpTo);
            var actualOutput = writer.ToString();

            // Assert
            Assert.Equal(
               expectedOutput,
               actualOutput.Replace("\n", "").Replace("\r", "")
           );
        }
    }
}
