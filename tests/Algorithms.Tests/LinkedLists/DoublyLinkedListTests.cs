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
    }
}
