using Algorithms.LinkedLists;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.LinkedLists
{
    public class MiddleLinkedListTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MiddleNode_ShouldReturnMiddleNode(ListNode listNode, ListNode middleOfLinkedList)
        {
            var result = MiddleLinkedList.MiddleNode(listNode);

            Assert.Equivalent(middleOfLinkedList, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { CreateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }), CreateLinkedList(new int[] { 4, 5, 6 }) };
            yield return new object[] { CreateLinkedList(new int[] { 1, 2, 3, 4, 5 }), CreateLinkedList(new int[] { 3, 4, 5 }) };
        }

        private static ListNode CreateLinkedList(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }
    }
}