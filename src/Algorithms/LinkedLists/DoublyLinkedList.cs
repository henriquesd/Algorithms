using System.Collections;

namespace Algorithms.LinkedLists
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }

        // The next node in the linked list (null if last node);
        public DoublyLinkedListNode<T> Next { get; set; }

        // The previous node in the linked list (null if first node);
        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }
    }

    public class DoublyLinkedList<T> : ICollection<T>
    {
        // The first node in the list or null if empty;
        public DoublyLinkedListNode<T> Head
        {
            get;
            private set;
        }

        // The last node in the list or null if empty;
        public DoublyLinkedListNode<T> Tail
        {
            get;
            private set;
        }

        #region Add

        // Adds the specified value to the start of the linked list;
        public void AddHead(T value)
        {
            AddHead(new DoublyLinkedListNode<T>(value));
        }

        // Adds the specified node to the start of the linked list;
        public void AddHead(DoublyLinkedListNode<T> node)
        {
            // Save off the head node so we don't lose it;
            DoublyLinkedListNode<T> temp = Head;

            // Point head to the new node;
            Head = node;

            // Insert the rest of the list behind the head;
            Head.Next = temp;

            if (Count == 0)
            {
                // if the list was empty then Head and Tail should
                // both point to the new node;
                Tail = Head;
            }
            else
            {
                // temp.Previous was null, now Head;
                temp.Previous = Head;
            }

            Count++;
        }

        // Add the value to the end of the list;
        public void AddTail(T value)
        {
            AddTail(new DoublyLinkedListNode<T>(value));
        }

        // Add the node to the end of the list;
        public void AddTail(DoublyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;

                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }
        #endregion

        #region Remove
        // Removes the first node from the list;
        public void RemoveHead()
        {
            if (Count != 0)
            {
                Head = Head.Next;

                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        // Removes the last node from the list;
        public void RemoveTail()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }
        #endregion

        #region ICollection

        // The number of items currently in the list;
        public int Count
        {
            get;
            private set;
        }

        // Adds the specified value to the front of the list;
        public void Add(T item)
        {
            AddHead(item);
        }

        public DoublyLinkedListNode<T> Find(T item)
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Returns true if the list contains the specified item,
        // false otherwise;
        public bool Contains(T item)
        {
            return Find(item) != null;
        }

        // Copies the node values into the specified array;
        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        // True if the collection is readonly, false otherwise;
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        // Removes the first occurance of the item from the list (searching from Head to Tail);
        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> found = Find(item);
            if (found == null)
            {
                return false;
            }

            DoublyLinkedListNode<T> previous = found.Previous;
            DoublyLinkedListNode<T> next = found.Next;

            if (previous == null)
            {
                // we are removing the head node;
                Head = next;
                if (Head != null)
                {
                    Head.Previous = null;
                }
            }
            else
            {
                previous.Next = next;
            }

            if (next == null)
            {
                // we are removing the tail;
                Tail = previous;
                if (Tail != null)
                {
                    Tail.Next = null;
                }
            }
            else
            {
                next.Previous = previous;
            }

            Count--;

            return true;
        }

        // Enumerates over the linked list values from Head to Tail;
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> GetReverseEnumerator()
        {
            DoublyLinkedListNode<T> current = Tail;
            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }

        // Removes all the nodes from the list;
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        #endregion

        public bool GetHead(out T value)
        {
            if (Count > 0)
            {
                value = Head.Value;
                return true;
            }

            value = default(T);
            return false;
        }

        public bool GetTail(out T value)
        {
            if (Count > 0)
            {
                value = Tail.Value;
                return true;
            }

            value = default(T);
            return false;
        }
    }
}
