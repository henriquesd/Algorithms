using Algorithms;
using Algorithms.BinarySearchs.BinaryTree;
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
        readonly TreeNode node = new TreeNode(1)
        {
            right = new TreeNode(2)
            {
                left = new TreeNode(3)
            }
        };

        [Benchmark(Description = "Recursive Approach")]
        public void RunRecursiveApproach()
        {
            BinaryTreePreorderTraversal.RecursiveApproach(node);
        }

        [Benchmark(Description = "Iterative Approach using a Stack")]
        public void RunIterativeApproach()
        {
            BinaryTreePreorderTraversal.IterativeApproach(node);
        }

        [Benchmark(Description = "Moris Traversal Approach")]
        public void RunMorisTraversalApproach()
        {
            BinaryTreePreorderTraversal.MorisTraversalApproach(node);
        }
    }
}