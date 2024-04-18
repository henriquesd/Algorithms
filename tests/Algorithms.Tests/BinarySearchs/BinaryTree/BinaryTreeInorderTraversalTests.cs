using Algorithms.BinarySearchs.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.BinarySearchs.BinaryTree
{
    public class BinaryTreeInorderTraversalTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void RecursiveApproach_ReturnExpectedResult(TreeNode root, List<int> expectedValue)
        {
            // Act
            var result = BinaryTreeInorderTraversal.RecursiveApproach(root);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void StackApproach_ReturnExpectedResult(TreeNode root, List<int> expectedValue)
        {
            // Act
            var result = BinaryTreeInorderTraversal.StackApproach(root);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MorrisTraversalApproach_ReturnExpectedResult(TreeNode root, List<int> expectedValue)
        {
            // Act
            var result = BinaryTreeInorderTraversal.MorrisTraversalApproach(root);

            // Assert
            Assert.Equal(expectedValue, result);
        }


        public static IEnumerable<object[]> ValuesToTest()
        {
            // Test 1: Tree with nodes [1,null,2,3]
            //       1
            //        \
            //         2
            //        /
            //       3
            yield return new object[]
            {
                new TreeNode(1)
                {
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(3)
                    }
                },
                new List<int> { 1, 3, 2 }
            };

            // Test 2: Empty tree
            yield return new object[]
            {
                null,
                new List<int>()
            };

            // Test 3: Tree with a single node
            yield return new object[]
            {
                new TreeNode(1),
                new List<int> { 1 }
            };

            // Test 4: Tree with nodes [1,2,3,null,null,4,5]
            //       1
            //      / \
            //     2   3
            //        / \
            //       4   5
            yield return new object[]
            {
                new TreeNode(1)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(3)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(5)
                    }
                },
                new List<int> { 2, 1, 4, 3, 5}
            };

            // Test 5: Tree with nodes [1,null,2,null,3,null,4,null,5]
            //        1
            //         \
            //          2
            //           \
            //            3
            //             \
            //              4
            //               \
            //                5
            yield return new object[]
            {
                new TreeNode(1)
                {
                    right = new TreeNode(2)
                    {
                        right = new TreeNode(3)
                        {
                            right = new TreeNode(4)
                            {
                                right = new TreeNode(5)
                            }
                        }
                    }
                },
                new List<int> { 1, 2, 3, 4, 5 }
             };

            // Test 6: Tree with a single node having value 0
            //       0
            yield return new object[]
            {
                new TreeNode(0),
                new List<int> { 0 }
            };

            // Test 7: Tree with nodes [1, 2, 3, 4, 5, 6, null]
            //       1
            //     /   \
            //    2     3
            //   / \   / 
            //  4   5 6
            yield return new object[]
            {
                new TreeNode(1)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(5)
                    },
                    right = new TreeNode(3)
                    {
                        left = new TreeNode(6)
                    }
                },
                new List<int> { 4, 2, 5, 1, 6, 3 }
             };
        }
    }
}