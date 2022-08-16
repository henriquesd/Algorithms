using Algorithms.BinaryTree;
using Algorithms.LinkedLists;
using System.Linq;
using Xunit;

namespace Algorithms.Tests.BinaryTree
{
    public class BinaryTreeTests
    {
        [Fact]
        public void InsertValuesOnTree_ShouldInsert()
        {
            int[] expectedValues = new int[] { 2, 1, 4, 3 };

            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(2);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Add(3);

            AssertTreePreOrder(binaryTree, expectedValues);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(7, false)]
        public void Contains_ShouldReturnExpectedValue(int value, bool expectedValue)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(2);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Add(3);

            var result = binaryTree.Contains(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(7, false)]
        public void Remove_ShouldReturnExpectedValue(int value, bool expectedValue)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(2);
            tree.Add(1);
            tree.Add(4);
            tree.Add(3);

            var result = tree.Remove(value);

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void Remove_ShouldRemoveLeafNode()
        {
            //          3
            //      1      4
            //        2
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Add(2);

            binaryTree.Remove(2);
            AssertTreePreOrder(binaryTree, new int[] { 3, 1, 4 });

            binaryTree.Remove(4);
            AssertTreePreOrder(binaryTree, new int[] { 3, 1 });

            binaryTree.Remove(1);
            AssertTreePreOrder(binaryTree, new int[] { 3 });
        }


        [Fact]
        public void Remove_ShouldRemoveOneChildRight()
        {
            //          3
            //      1      4
            //        2
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Add(2);

            binaryTree.Remove(1);
            AssertTreePreOrder(binaryTree, new int[] { 3, 2, 4 });
        }


        [Fact]
        public void Remove_ShouldRemoveOneChildLeft()
        {
            //          3
            //      2      4
            //     1
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);
            binaryTree.Add(2);
            binaryTree.Add(4);
            binaryTree.Add(1);

            binaryTree.Remove(2);
            AssertTreePreOrder(binaryTree, new int[] { 3, 1, 4 });
        }


        [Fact]
        public void Remove_ShouldRemoveTwoChild()
        {
            //          10
            //      5       11
            //     4  9
            //    3  7
            //        8
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(4);
            binaryTree.Add(9);
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(11);

            //          10
            //      7       11
            //     4  9
            //    3  8
            //        
            binaryTree.Remove(5);
            AssertTreePreOrder(binaryTree, new int[] { 10, 7, 4, 3, 9, 8, 11 });
        }

        [Fact]
        public void Remove_ShouldRemoveRoot_TwoChild()
        {
            //          10
            //      5        20
            //    4   6    15
            //           12
            //             13
            //               14
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(4);
            binaryTree.Add(6);

            binaryTree.Add(20);
            binaryTree.Add(15);
            binaryTree.Add(12);
            binaryTree.Add(13);
            binaryTree.Add(14);

            //          12
            //      5        20
            //    4   6    15
            //           13
            //             14
            //               
            binaryTree.Remove(10);
            AssertTreePreOrder(binaryTree, new int[] { 12, 5, 4, 6, 20, 15, 13, 14 });


            //          13
            //      5        20
            //    4   6    15
            //           14
            //               
            binaryTree.Remove(12);
            AssertTreePreOrder(binaryTree, new int[] { 13, 5, 4, 6, 20, 15, 14 });
        }

        [Fact]
        public void Remove_ShouldRemoveRoot_OneChildLeft()
        {
            //          3
            //      2
            //     1
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);
            binaryTree.Add(2);
            binaryTree.Add(1);

            binaryTree.Remove(3);
            AssertTreePreOrder(binaryTree, new int[] { 2, 1 });
        }

        [Fact]
        public void Remove_ShouldRemoveRoot_OneChildRight()
        {
            //          3
            //            4
            //              5
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);

            binaryTree.Remove(3);
            AssertTreePreOrder(binaryTree, new int[] { 4, 5 });
        }

        [Fact]
        public void Remove_ShouldRemoveRoot_Only()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(3);

            binaryTree.Remove(3);
            AssertTreePreOrder(binaryTree, new int[] { });
        }

        [Fact]
        public void PreOrderTraversal_ShouldReturnAExactlySameTree()
        {
            //          10
            //      5        20
            //    4   6    15
            //           12
            //             13
            //               14
            BinaryTree<int> expectedBinaryTree = new BinaryTree<int>();
            expectedBinaryTree.Add(10);
            expectedBinaryTree.Add(5);
            expectedBinaryTree.Add(4);
            expectedBinaryTree.Add(6);

            expectedBinaryTree.Add(20);
            expectedBinaryTree.Add(15);
            expectedBinaryTree.Add(12);
            expectedBinaryTree.Add(13);
            expectedBinaryTree.Add(14);

            BinaryTree<int> actualBinaryTree = new BinaryTree<int>();
            expectedBinaryTree.PreOrderTraversal((value) => actualBinaryTree.Add(value));

            AssertTreesSame(actualBinaryTree, expectedBinaryTree);
        }

        private int[] TreeToPreorderArray(BinaryTree<int> tree)
        {
            DoublyLinkedList<int> actualList = new DoublyLinkedList<int>();
            tree.PreOrderTraversal((value) => actualList.AddTail(value));
            return actualList.ToArray();
        }

        private void AssertTreesSame(BinaryTree<int> actual, BinaryTree<int> expected)
        {
            AssertArraysSame(TreeToPreorderArray(actual), TreeToPreorderArray(expected));
        }

        private void AssertArraysSame(int[] actual, int[] expected)
        {
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        private void AssertTreePreOrder(BinaryTree<int> tree, int[] expected)
        {
            Assert.Equal(tree.Count, expected.Length);

            int[] actual = TreeToPreorderArray(tree);

            AssertArraysSame(actual, expected);
        }
    }
}