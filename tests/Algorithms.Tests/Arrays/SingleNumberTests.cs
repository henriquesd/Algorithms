using Algorithms.Arrays;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class SingleNumberTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SingleNumberExample1_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = SingleNumber.SingleNumberExample1(inputArray);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SingleNumberExample2_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = SingleNumber.SingleNumberExample2(inputArray);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SingleNumberExample3_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = SingleNumber.SingleNumberExample3(inputArray);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SingleNumberExample4_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = SingleNumber.SingleNumberExample4(inputArray);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 2, 2, 1 }, 1 }; // Basic case with three elements where one element appears once
            yield return new object[] { new int[] { 4, 1, 2, 1, 2 }, 4 }; // Mixed case with five elements where one element appears once
            yield return new object[] { new int[] { 1 }, 1 }; // Single element array
            yield return new object[] { new int[] { 2, 3, 2 }, 3 }; // Another simple case with three elements where one element appears once
            yield return new object[] { new int[] { 0, 1, 0, 1, 99 }, 99 }; // Array with zero and another number appearing twice, and one element appearing once
            yield return new object[] { new int[] { -1, -1, -2 }, -2 }; // Array with negative numbers where one element appears once
            yield return new object[] { new int[] { int.MaxValue, int.MaxValue, int.MinValue }, int.MinValue }; // Array with extreme values (int.MaxValue and int.MinValue)
        }
    }
}