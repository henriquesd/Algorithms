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

        [Benchmark(Description = "Palindromes IsPalindromeUsingLinq")]
        public void RunPalindromesUsingLinq()
        {
            Palindromes.IsPalindromeUsingLinq("abba");
        }

        [Benchmark(Description = "RemoveRepeatedValues RemoveDuplicatesFromSortedArray")]
        public void RunRemoveRepeatedValues()
        {
            RemoveRepeatedValues.RemoveDuplicatesFromSortedArray(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "RemoveRepeatedValues RemoveRepeatedValuesFromArray")]
        public void RunRemoveRepeatedValuesFromArray()
        {
            RemoveRepeatedValues.RemoveRepeatedValuesFromArray(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "RemoveRepeatedValues RemoveRepeatedValuesWithLinq")]
        public void RunRemoveRepeatedValuesWithLinq()
        {
            RemoveRepeatedValues.RemoveRepeatedValuesWithLinq(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 });
        }

        [Benchmark(Description = "ReverseArray")]
        public void RunReverseArray()
        {
            ReverseArray.ReverseArrayIntoNewArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [Benchmark(Description = "ReverseInt Reverse")]
        public void RunReverseInt()
        {
            ReverseInt.Reverse(981);
        }

        [Benchmark(Description = "ReverseInt ReverseWithString")]
        public void RunReverseIntReverseWithString()
        {
            ReverseInt.ReverseWithString(981);
        }

        [Benchmark(Description = "ReverseInt ReverseExample3")]
        public void RunReverseIntReverseExample3()
        {
            ReverseInt.ReverseExample3(981);
        }

        [Benchmark(Description = "ReverseString")]
        public void RunReverseString()
        {
            ReverseString.Reverse("reverse string");
        }

        [Benchmark(Description = "ReverseString ReverseUsingLinq")]
        public void RunReverseStringReverseUsingLinq()
        {
            ReverseString.ReverseUsingLinq("reverse string");
        }

        [Benchmark(Description = "ReverseString ReverseWithStringBuilder")]
        public void RunReverseStringReverseWithStringBuilder()
        {
            ReverseString.ReverseWithStringBuilder("reverse string");
        }

        [Benchmark(Description = "ReverseString-ReverseEachWord")]
        public void RunReverseStringReverseEachWord()
        {
            ReverseString.ReverseEachWord("reverse string");
        }

        [Benchmark(Description = "SmallestPositiveValue Execute")]
        public void RunSmallestPositiveValue()
        {
            SmallestPositiveValue.Execute(new int[] { 1, 3, 4, 6, 2 });
        }

        [Benchmark(Description = "SmallestPositiveValue ExecuteWithSortedArray")]
        public void RunSmallestPositiveValueWithSortedArray()
        {
            SmallestPositiveValue.ExecuteWithSortedArray(new int[] { 1, 3, 4, 6, 2 });
        }

        [Benchmark(Description = "DiagonalDifference MatrixDiagonalDifference")]
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

        [Benchmark(Description = "Staircase Execute")]
        public void Staircase1()
        {
            Staircase.ExecuteExample1(7);
        }

        [Benchmark(Description = "Staircase Execute2")]
        public void Staircase2()
        {
            Staircase.ExecuteExample2(7);
        }

        [Benchmark(Description = "MiniMaxSum ExecuteMiniMaxSumList")]
        public void MiniMaxSumExecuteMiniMaxSumList()
        {
            MiniMaxSum.ExecuteMiniMaxSumList(new List<int> { 5, 1, 3, 9, 7 });
        }

        [Benchmark(Description = "MiniMaxSum ExecuteMiniMaxSumArray")]
        public void MiniMaxSumExecuteMiniMaxSumArray()
        {
            MiniMaxSum.ExecuteMiniMaxSumArray(new int[] { 5, 1, 3, 9, 7 });
        }

        [Benchmark(Description = "MiniMaxSum ExecuteMiniMaxSumWithLinq")]
        public void MiniMaxSumExecuteExecuteMiniMaxSumWithLinq()
        {
            MiniMaxSum.ExecuteMiniMaxSumWithLinq(new List<int> { 5, 1, 3, 9, 7 });
        }

        [Benchmark(Description = "RepeatedNumberArray CountMostRepeatedNumberWithTuple")]
        public void RepeatedNumberArrayCountMostRepeatedNumberWithTuple()
        {
            RepeatedNumberArray.CountMostRepeatedNumberWithTuple(new int[] { 3, 2, 1, 3, 7, 3 });
        }

        [Benchmark(Description = "RepeatedNumberArray CountMostRepeatedNumberWithDictionary")]
        public void RepeatedNumberArrayCountMostRepeatedNumberWithDictionary()
        {
            RepeatedNumberArray.CountMostRepeatedNumberWithDictionary(new int[] { 3, 2, 1, 3, 7, 3 });
        }

        [Benchmark(Description = "MergeArrays Merge1")]
        public void MergeArraysMerge1()
        {
            MergeArrays.Merge1(new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 2, 5, 6 });
        }

        [Benchmark(Description = "MergeArrays Merge2")]
        public void MergeArraysMerge2()
        {
            MergeArrays.Merge2(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        [Benchmark(Description = "ArabicNumberToRomanNumeral ConvertExample1")]
        public void ArabicNumberToRomanNumeralConvertExample1()
        {
            ArabicNumberToRomanNumeral.ConvertExample1(37);
        }

        [Benchmark(Description = "ArabicNumberToRomanNumeral ConvertExample2")]
        public void ArabicNumberToRomanNumeralConvertExample2()
        {
            ArabicNumberToRomanNumeral.ConvertExample2(37);
        }

        [Benchmark(Description = "ConvertTime Convert")]
        public void ConvertTimeConvert()
        {
            ConvertTime.Convert("04:37:22PM");
        }

        [Benchmark(Description = "ConvertTime ConvertToMilitaryTime")]
        public void ConvertTimeConvertToMilitaryTime()
        {
            ConvertTime.ConvertToMilitaryTime("04:37:22PM");
        }

        [Benchmark(Description = "RemoveElement Remove")]
        public void RemoveElementRemove()
        {
            RemoveElement.Remove(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        }

        [Benchmark(Description = "MajorityElement Find")]
        public void MajorityElementFind()
        {
            MajorityElement.Find(new int[] { 3, 2, 3 });
        }

        [Benchmark(Description = "MajorityElement FindMajorityElement")]
        public void MajorityElementFindMajorityElement()
        {
            MajorityElement.FindMajorityElement(new int[] { 3, 2, 3 });
        }

        [Benchmark(Description = "RomanToInteger Convert")]
        public void RomanToIntegerConvert()
        {
            RomanToInteger.Convert("LXXXVII");
        }
    }
}