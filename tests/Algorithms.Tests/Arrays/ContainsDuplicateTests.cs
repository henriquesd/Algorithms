using Algorithms.Arrays;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class ContainsDuplicateTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void ContainsDuplicateExample1_ShouldReturnExpectedResult(int[] inputArray, bool expectedResult)
        {
            var result = ContainsDuplicate.ContainsDuplicateExample1(inputArray);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void ContainsDuplicateExample2_ShouldReturnExpectedResult(int[] inputArray, bool expectedResult)
        {
            var result = ContainsDuplicate.ContainsDuplicateExample2(inputArray);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 1, 2, 3, 1 }, true }; // Duplicate element exists
            yield return new object[] { new int[] { 1, 2, 3, 4 }, false }; // All elements are unique
            yield return new object[] { new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true }; // Multiple duplicates
            yield return new object[] { new int[] { 1 }, false }; // Single element array
            yield return new object[] { new int[] { }, false }; // Empty array
            yield return new object[] { new int[] { 2, 2, 2, 2, 2 }, true }; // Array with all elements the same
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false }; // Array with no duplicates
        }
    }
}