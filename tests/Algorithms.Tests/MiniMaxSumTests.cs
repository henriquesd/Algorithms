using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class MiniMaxSumTests
    {
        [Theory]
        [MemberData(nameof(ListOfInt))]
        public void ExecuteMiniMaxSumList_ShouldReturnMinAndMaxSum(List<int> inputArray, string expectedResult)
        {
            // Act
            var result = MiniMaxSum.ExecuteMiniMaxSumList(inputArray);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ListOfInt))]
        public void ExecuteMiniMaxSumWithLinq_ShouldReturnMinAndMaxSum(List<int> inputArray, string expectedResult)
        {
            // Act
            var result = MiniMaxSum.ExecuteMiniMaxSumWithLinq(inputArray);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ListOfInt()
        {
            yield return new object[] { new List<int> { }, "" };
            yield return new object[] { new List<int> { 5, 1, 3, 9, 7 }, "16 24" };
            yield return new object[] { new List<int> { 0, 5, 1, 3, 9, 7 }, "16 25" };
            yield return new object[] { new List<int> { 1, 3, 5, 7, 9 }, "16 24" };
            yield return new object[] { new List<int> { 47 }, "47" };
            yield return new object[] { new List<int> { 40, 78 }, "40 78" };
        }

        [Theory]
        [InlineData(new int[] { }, "")]
        [InlineData(new int[] { 5, 1, 3, 9, 7 }, "16 24")]
        [InlineData(new int[] { 0, 5, 1, 3, 9, 7 }, "16 25")]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, "16 24")]
        [InlineData(new int[] { 47 }, "47")]
        [InlineData(new int[] { 40, 78 }, "40 78")]
        public void ExecuteMiniMaxSumArray_ShouldReturnMinAndMaxSum(int[] inputArray, string expectedResult)
        {
            // Act
            var result = MiniMaxSum.ExecuteMiniMaxSumArray(inputArray);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}