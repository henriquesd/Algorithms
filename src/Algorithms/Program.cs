using Algorithms;
using Algorithms.Simulation;
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
        [Benchmark(Description = "Example 0")]
        public void RunTimeNeededToBuyTicketsExample0()
        {
            TimeNeededToBuyTickets.TimeRequiredToBuyExample0(new int[] { 2, 3, 2 }, 2);
        }

        [Benchmark(Description = "Example 1")]
        public void RunTimeNeededToBuyTicketsExample1()
        {
            TimeNeededToBuyTickets.TimeRequiredToBuyExample1(new int[] { 2, 3, 2 }, 2);
        }

        [Benchmark(Description = "Example 2")]
        public void RunTimeNeededToBuyTicketsExample2()
        {
            TimeNeededToBuyTickets.TimeRequiredToBuyExample2(new int[] { 2, 3, 2 }, 2);
        }

        [Benchmark(Description = "Example 3")]
        public void RunTimeNeededToBuyTicketsExample3()
        {
            TimeNeededToBuyTickets.TimeRequiredToBuyExample3(new int[] { 2, 3, 2 }, 2);
        }
    }
}