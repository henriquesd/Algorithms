using System.IO;
using System;
using Xunit;
using Algorithms.Strings;

namespace Algorithms.Tests.Strings
{
    public class StaircaseTests
    {
        [Fact]
        public void Staircase_ExecuteExample1_ShouldPrintCorrectly()
        {
            // Arrange
            int n = 4;
            string expectedOutput = "   #\n  ##\n ###\n####\n";

            // Redirect console output to a StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Staircase.ExecuteExample1(n);

                // Normalize the line endings in actualOutput to '\n'
                string actualOutput = sw.ToString().Replace("\r\n", "\n");

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
        }

        [Fact]
        public void Staircase_ExecuteExample2_ShouldPrintCorrectly()
        {
            // Arrange
            int n = 4;
            string expectedOutput = "   #\n  ##\n ###\n####\n";

            // Redirect console output to a StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Staircase.ExecuteExample2(n);

                // Normalize the line endings in actualOutput to '\n'
                string actualOutput = sw.ToString().Replace("\r\n", "\n");

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
        }
    }
}
