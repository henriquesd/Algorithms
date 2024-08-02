using Algorithms.Strings;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class FirstUniqueCharacterInStringTests
    {
        [Theory]
        [InlineData("code", 0)] // Test case where the first non-repeating character is at index 0;
        [InlineData("lovealgorithms", 2)] // Test case where the first non-repeating character is at index 2;
        [InlineData("aabb", -1)] // Test case where there are no non-repeating characters;
        [InlineData("z", 0)] // Test case with a single character;
        [InlineData("abc", 0)]  // Test case with all characters unique;
        [InlineData("aabbccd", 6)]  // Test case with non-repeating character at the end;
        public void FirstUniqueCharacterInString_ShouldReturnFirstUniqueCharacter(string input, int expected)
        {
            var result = FirstUniqueCharacterInString.FirstUniqChar(input);

            Assert.Equal(expected, result);
        }
    }
}