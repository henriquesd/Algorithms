using Algorithms.LinkedLists;
using Xunit;

namespace Algorithms.Tests.LinkedLists
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void AddHead_ShouldAddValueToHead()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddHead(i);
            }

            // Result:
            // 5        4       3       2       1
            // null <- prev <- prev <- prev <- prev 
            // next -> next -> next -> next -> null
            Assert.Equal(5, doublyLinkedList.Count);
            Assert.Equal(5, doublyLinkedList.Head.Value);
            Assert.Equal(4, doublyLinkedList.Head.Next.Value);
            Assert.Null(doublyLinkedList.Head.Previous);
            Assert.Equal(1, doublyLinkedList.Tail.Value);
            Assert.Equal(2, doublyLinkedList.Tail.Previous.Value);
            Assert.Null(doublyLinkedList.Tail.Next);
        }

        [Fact]
        public void AddTail_ShouldAddValueToTail()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            // Result:
            // 1        2       3       4       5
            // null <- prev <- prev <- prev <- prev 
            // next -> next -> next -> next -> null
            Assert.Equal(5, doublyLinkedList.Count);
            Assert.Equal(5, doublyLinkedList.Tail.Value);
            Assert.Equal(4, doublyLinkedList.Tail.Previous.Value);
            Assert.Null(doublyLinkedList.Tail.Next);
            Assert.Null(doublyLinkedList.Head.Previous);
            Assert.Equal(1, doublyLinkedList.Head.Value);
            Assert.Equal(2, doublyLinkedList.Head.Next.Value);
        }

        [Fact]
        public void Find_ShouldReturnSearchedValue_WhenValueExists()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            var result = doublyLinkedList.Find(doublyLinkedList.Tail.Value);

            Assert.Equal(5, result.Value);
            Assert.Equal(4, result.Previous.Value);
            Assert.Null(result.Next);
        }

        [Fact]
        public void Find_ShouldReturnNull_WhenSearchedValueDoesNotExist()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            var result = doublyLinkedList.Find(6);

            Assert.Null(result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(6, false)]
        public void Contains_ShouldReturnExpectedValue(int value, bool expectedValue)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            var result = doublyLinkedList.Contains(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(6, false)]
        public void Remove_ShouldReturnExpectedValue(int value, bool expectedValue)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            var result = doublyLinkedList.Remove(value);

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void Remove_ShouldRemoveCorrectNode_WhenThreeNodesExists()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 3; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            // Before removing
            // 1        2       3
            // null <- prev <- prev
            // next -> next -> null

            doublyLinkedList.Remove(2);

            // Result:
            // 1        3
            // null <- prev
            // next -> null
            Assert.Equal(2, doublyLinkedList.Count);
            Assert.Equal(3, doublyLinkedList.Tail.Value);
            Assert.Equal(1, doublyLinkedList.Tail.Previous.Value);
            Assert.Null(doublyLinkedList.Tail.Next);
            Assert.Null(doublyLinkedList.Head.Previous);
            Assert.Equal(1, doublyLinkedList.Head.Value);
            Assert.Equal(3, doublyLinkedList.Head.Next.Value);
        }

        [Fact]
        public void Remove_ShouldRemoveCorrectNode_WhenFiveNodesExist()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                doublyLinkedList.AddTail(i);
            }

            // Before removing
            // 1        2       3       4       5
            // null <- prev <- prev <- prev <- prev
            // next -> next -> next -> next -> null

            doublyLinkedList.Remove(3);

            // Result:
            // 1        2       4       5
            // null <- prev <- prev <- prev
            // next -> next -> next -> null
            Assert.Equal(4, doublyLinkedList.Count);
            Assert.Equal(5, doublyLinkedList.Tail.Value);
            Assert.Equal(4, doublyLinkedList.Tail.Previous.Value);
            Assert.Null(doublyLinkedList.Tail.Next);
            Assert.Null(doublyLinkedList.Head.Previous);
            Assert.Equal(1, doublyLinkedList.Head.Value);
            Assert.Equal(2, doublyLinkedList.Head.Next.Value);
        }
    }
}
