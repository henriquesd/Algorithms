using Algorithms;
using Algorithms.BinarySearchs.BinaryTree;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using static Algorithms.BinarySearchs.BinaryTree.BinaryTreePreorderTraversal;

BenchmarkRunner.Run<AlgorithmsProgram>();

namespace Algorithms
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MarkdownExporter]
    public class AlgorithmsProgram
    {
        readonly TreeNode node = new TreeNode(1)
        {
            right = new TreeNode(2)
            {
                left = new TreeNode(3)
            }
        };

        [Benchmark(Description = "PreorderTraversalExample1")]
        public void PreorderTraversalExample1()
        {
            BinaryTreePreorderTraversal.PreorderTraversalExample1(node);
        }

        [Benchmark(Description = "PreorderTraversalExample2")]
        public void PreorderTraversalExample2()
        {
            BinaryTreePreorderTraversal.PreorderTraversalExample2(node);
        }

        [Benchmark(Description = "PreorderTraversalExample3")]
        public void PreorderTraversalExample3()
        {
            BinaryTreePreorderTraversal.PreorderTraversalExample3(node);
        }
    }
}