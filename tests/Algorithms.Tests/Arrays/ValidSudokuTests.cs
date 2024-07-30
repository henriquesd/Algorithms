using Algorithms.Arrays;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class ValidSudokuTests
    {
        [Theory]
        [MemberData(nameof(BoardsToTest))]
        public void IsValidSudoku_ShouldReturnIfSudokuBoardIsValid(char[][] board, bool isValid)
        {
            var result = ValidSudoku.IsValidSudoku(board);

            Assert.Equal(result, isValid);
        }

        public static IEnumerable<object[]> BoardsToTest()
        {
            yield return new object[]
           {
                new char[][]
                {
                    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                },
                true
           };

            yield return new object[]
            {
                new char[][]
                {
                    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '7'} // Invalid row (two '7's)
                },
                false
            };

            yield return new object[]
            {
                new char[][]
                {
                    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '5'} // Invalid column (two '5's)
                },
                false
            };

            yield return new object[]
            {
                new char[][]
                {
                    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new char[] {'9', '.', '.', '.', '8', '.', '.', '7', '9'} // Invalid sub-box (two '9's)
                },
                false
            };

            yield return new object[]
            {
                new char[][]
                {
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                    new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'}
                },
                true
            };
        }
    }
}