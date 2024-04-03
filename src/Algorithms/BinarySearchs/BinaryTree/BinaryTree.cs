namespace Algorithms.BinarySearchs.BinaryTree
{
    // A binary tree node class - encapsulates the value and left/right pointers.
    internal class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }

        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }

        // Compares the current node to the provided value
        // returns 1 if the instance value is greater than the provided value,
        // returns -1 if less or 0 if equal;
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> Root { get; set; }

        #region Add

        // Adds the provided value to the binary tree.
        public void Add(T value)
        {
            // Case 1: The tree is empty - allocate the head
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(value);
            }
            // Case 2: The tree is not empty so find the right location to insert
            else
            {
                AddTo(Root, value);
            }

            Count++;
        }

        // Recursive add algorithm
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Case 1: Value is less than the current node value
            if (value.CompareTo(node.Value) < 0)
            {
                // if there is no left child make this the new left
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else add it to the left node
                    AddTo(node.Left, value);
                }
            }
            // Case 2: Value is equal to or greater than the current value
            else
            {
                // If there is no right, add it to the right
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else add it to the right node
                    AddTo(node.Right, value);
                }
            }
        }
        #endregion

        // Determines if the specified value exists in the binary tree.
        // Returns true if the tree contains the value, false otherwise;
        public bool Contains(T value)
        {
            // defer to the node search helper function.
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        // Finds and returns the first node containing the specified value. If the value
        // is not found, returns null.  Also returns the parent of the found node (or null)
        // which is used in Remove.
        // Returns The found node (or null);
        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            // Now, try to find data in the tree
            BinaryTreeNode<T> current = Root;
            parent = null;

            // while we don't have a match
            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    // if the value is less than current, go left.
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // if the value is more than current, go right.
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // we have a match!
                    break;
                }
            }

            return current;
        }

        #region Remove
        // Removes the first occurance of the specified value from the tree.
        // Returns true if the value was removed, false otherwise;
        public bool Remove(T value)
        {
            BinaryTreeNode<T> current, parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            Count--;

            // Case 1: If current has no right child, then current's left replaces current;
            if (current.Right == null)
            {
                if (parent == null)
                {
                    Root = current.Left;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make the current left child a left child of parent;
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        // if parent value is less than current value
                        // make the current left child a right child of parent;
                        parent.Right = current.Left;
                    }
                }
            }
            // Case 2: If current's right child has no left child, then current's right child replaces current;
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    Root = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make the current right child a left child of parent;
                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        // if parent value is less than current value
                        // make the current right child a right child of parent;
                        parent.Right = current.Right;
                    }
                }
            }
            // Case 3: If current's right child has a left child, replace current with current's
            //  right child's left-most child;
            else
            {
                // find the right's left-most child;
                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;

                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                // the parent's left subtree becomes the leftmost's right subtree;
                leftmostParent.Left = leftmost.Right;

                // assign leftmost's left and right to current's left and right children;
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                {
                    Root = leftmost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make leftmost the parent's left child;
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        // if parent value is less than current value
                        // make leftmost the parent's right child;
                        parent.Right = leftmost;
                    }
                }
            }

            return true;
        }
        #endregion

        #region Pre-Order Traversal
        // Performs the provided action on each binary tree value in pre-order traversal order;
        public void PreOrderTraversal(Action<T> action)
        {
            PreOrderTraversal(action, Root);
        }

        private void PreOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                action(node.Value);
                PreOrderTraversal(action, node.Left);
                PreOrderTraversal(action, node.Right);
            }
        }
        #endregion

        #region Post-Order Traversal
        // Performs the provided action on each binary tree value in post-order traversal order;
        public void PostOrderTraversal(Action<T> action)
        {
            PostOrderTraversal(action, Root);
        }

        private void PostOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(action, node.Left);
                PostOrderTraversal(action, node.Right);
                action(node.Value);
            }
        }
        #endregion

        #region In-Order Enumeration
        // Performs the provided action on each binary tree value in in-order traversal order;
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(action, Root);
        }

        private void InOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(action, node.Left);

                action(node.Value);

                InOrderTraversal(action, node.Right);
            }
        }

        /// Enumerates the values contains in the binary tree in in-order traversal order;
        public IEnumerator<T> InOrderTraversal()
        {
            // This is a non-recursive algorithm using a stack to demonstrate removing
            // recursion to make using the yield syntax easier;
            if (Root != null)
            {
                // store the nodes we've skipped in this stack (avoids recursion);
                Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

                BinaryTreeNode<T> current = Root;

                // when removing recursion we need to keep track of whether or not
                // we should be going to the left node or the right nodes next;
                bool goLeftNext = true;

                // start by pushing Head onto the stack;
                stack.Push(current);

                while (stack.Count > 0)
                {
                    // If we're heading left...
                    if (goLeftNext)
                    {
                        // push everything but the left-most node to the stack
                        // we'll yield the left-most after this block;
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    // in-order is left->yield->right
                    yield return current.Value;

                    // if we can go right then do so
                    if (current.Right != null)
                    {
                        current = current.Right;

                        // once we've gone right once, we need to start
                        // going left again.
                        goLeftNext = true;
                    }
                    else
                    {
                        // if we can't go right then we need to pop off the parent node
                        // so we can process it and then go to it's right node
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        // Returns an enumerator that performs an in-order traversal of the binary tree;
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }

        // Returns an enumerator that performs an in-order traversal of the binary tree;
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        // Removes all items from the tree;
        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        // Returns the number of items currently contained in the tree;
        public int Count { get; private set; }
    }
}
