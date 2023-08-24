using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using Algorithms;

BenchmarkRunner.Run<AlgorithmsProgram>();

namespace Algorithms
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MarkdownExporter]
    public class AlgorithmsProgram
    {
        [Benchmark(Description = "FizzBuzz Example 1")]
        public void RunFizzBuzzExample1()
        {
            FizzBuzz.ExecuteExample1(15);
        }

        [Benchmark(Description = "FizzBuzz Example 2")]
        public void RunFizzBuzz2()
        {
            FizzBuzz.ExecuteExample2(15);
        }

        [Benchmark(Description = "FizzBuzz Example 3")]
        public void RunFizzBuzzExample3()
        {
            FizzBuzz.ExecuteExample3(15);
        }

        [Benchmark(Description = "Anagram")]
        public void RunAnagram()
        {
            Anagram.AreAnagram("ana", "ana");
        }

        [Benchmark(Description = "BinarySearch")]
        public void RunBinarySearch()
        {
            BinarySearch.FindNumberPositionInSortedArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4);
        }

        [Benchmark(Description = "Palindromes")]
        public void RunPalindromes()
        {
            Palindromes.IsPalindrome("abba");
        }

        [Benchmark(Description = "Palindromes-IsPalindromeUsingLinq")]
        public void RunPalindromesUsingLinq()
        {
            Palindromes.IsPalindromeUsingLinq("abba");
        }

        [Benchmark(Description = "RemoveRepeatedValues-RemoveDuplicatesFromSortedArray")]
        public void RunRemoveRepeatedValues()
        {
            RemoveRepeatedValues.RemoveDuplicatesFromSortedArray(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "RemoveRepeatedValues-RemoveRepeatedValuesFromArray")]
        public void RunRemoveRepeatedValuesFromArray()
        {
            RemoveRepeatedValues.RemoveRepeatedValuesFromArray(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "RemoveRepeatedValues-RemoveRepeatedValuesWithLinq")]
        public void RunRemoveRepeatedValuesWithLinq()
        {
            RemoveRepeatedValues.RemoveRepeatedValuesWithLinq(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "ReverseArray")]
        public void RunReverseArray()
        {
            ReverseArray.ReverseArrayIntoNewArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [Benchmark(Description = "ReverseInt")]
        public void RunReverseInt()
        {
            ReverseInt.Reverse(981);
        }

        [Benchmark(Description = "ReverseString")]
        public void RunReverseString()
        {
            ReverseString.Reverse("reverse string");
        }

        [Benchmark(Description = "ReverseString-ReverseUsingLinq")]
        public void RunReverseStringReverseUsingLinq()
        {
            ReverseString.ReverseUsingLinq("reverse string");
        }

        [Benchmark(Description = "ReverseString-ReverseWithStringBuilder")]
        public void RunReverseStringReverseWithStringBuilder()
        {
            ReverseString.ReverseWithStringBuilder("reverse string");
        }

        [Benchmark(Description = "ReverseString-ReverseEachWord")]
        public void RunReverseStringReverseEachWord()
        {
            ReverseString.ReverseEachWord("reverse string");
        }

        [Benchmark(Description = "SmallestPositiveValue-Execute")]
        public void RunSmallestPositiveValue()
        {
            SmallestPositiveValue.Execute(new int[] { 1, 3, 4, 6, 2 });
        }

        [Benchmark(Description = "SmallestPositiveValue-ExecuteWithSortedArray")]
        public void RunSmallestPositiveValueWithSortedArray()
        {
            SmallestPositiveValue.ExecuteWithSortedArray(new int[] { 1, 3, 4, 6, 2 });
        }

        [Benchmark(Description = "DiagonalDifference-MatrixDiagonalDifference")]
        public void RunDiagonalDifference()
        {
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 9, 8, 9 }
            };

            DiagonalDifference.MatrixDiagonalDifference(matrix);
        }

        [Benchmark(Description = "Staircase-Execute")]
        public void Staircase1()
        {
            Staircase.ExecuteExample1(7);
        }

        [Benchmark(Description = "Staircase-Execute2")]
        public void Staircase2()
        {
            Staircase.ExecuteExample2(7);
        }
    }
}