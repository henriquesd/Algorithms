using Algorithms;
using Algorithms.Arrays;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<AlgorithmsProgram>();

namespace Algorithms
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MarkdownExporter]
    public class AlgorithmsProgram
    {
        [Benchmark(Description = "MoveZeroes 1")]
        public void RunMoveZeroes1()
        {
            MoveZeroes.MoveZeroesExample1(new int[] { 0, 1, 0, 3, 12 });
        }

        [Benchmark(Description = "MoveZeroes 2")]
        public void RunMoveZeroes2()
        {
            MoveZeroes.MoveZeroesExample2(new int[] { 0, 1, 0, 3, 12 });
        }

        [Benchmark(Description = "MoveZeroes 3")]
        public void RunMoveZeroes3()
        {
            MoveZeroes.MoveZeroesExample3(new int[] { 0, 1, 0, 3, 12 });
        }

        [Benchmark(Description = "MoveZeroes 4")]
        public void RunMoveZeroes4()
        {
            MoveZeroes.MoveZeroesExample1(new int[] { 0, 1, 0, 3, 12 });
        }

        [Benchmark(Description = "MoveZeroes 5")]
        public void RunMoveZeroes5()
        {
            MoveZeroes.MoveZeroesExample5(new int[] { 0, 1, 0, 3, 12 });
        }
    }
}