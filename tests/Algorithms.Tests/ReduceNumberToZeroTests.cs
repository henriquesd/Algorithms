using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class ReduceNumberToZeroTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void NumberOfStepsExample1_ShouldReturnExpectedResult(int n, int steps)
        {
            var result = ReduceNumberToZero.NumberOfStepsExample1(n);

            Assert.Equal(steps, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void NumberOfStepsExample2_ShouldReturnExpectedResult(int n, int steps)
        {
            var result = ReduceNumberToZero.NumberOfStepsExample2(n);

            Assert.Equal(steps, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void NumberOfStepsExample3_ShouldReturnExpectedResult(int n, int steps)
        {
            var result = ReduceNumberToZero.NumberOfStepsExample3(n);

            Assert.Equal(steps, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void NumberOfStepsBitwiseApproach_ShouldReturnExpectedResult(int n, int steps)
        {
            var result = ReduceNumberToZero.NumberOfStepsBitwiseApproach(n);

            Assert.Equal(steps, result);
        }
        
        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { 14, 6 };
            yield return new object[] { 8, 4 };
            yield return new object[] { 123, 12 };
        }
    }
}
