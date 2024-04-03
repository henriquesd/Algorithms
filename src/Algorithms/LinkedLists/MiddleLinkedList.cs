namespace Algorithms.LinkedLists
{
    /// <summary>
    /// Given the head of a singly linked list, return the middle node of the linked list.
    /// If there are two middle nodes, return the second middle node.
    /// </summary>
    public static class MiddleLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}