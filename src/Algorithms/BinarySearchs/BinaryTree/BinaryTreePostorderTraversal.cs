namespace Algorithms.BinarySearchs.BinaryTree
{
    public static class BinaryTreePostorderTraversal
    {
        // Recursive Approach
        public static IList<int> RecursiveApproach(TreeNode root)
        {
            List<int> result = new List<int>();

            Postorder(root, result);
            
            return result;
        }

        // Recursive helper method to perform postorder traversal
        private static void Postorder(TreeNode root, List<int> result)
        {
            if (root == null) return;

            // Traverse the left subtree
            Postorder(root.left, result);

            // Traverse the right subtree
            Postorder(root.right, result);

            // Visit the current node
            result.Add(root.val);
        }

        // Iterative approach using a Stack
        public static IList<int> IterativeApproach(TreeNode root)
        {
            // Initialize a list to store the result of the postorder traversal
            List<int> result = new List<int>();

            // Initialize a stack to perform iterative traversal
            Stack<TreeNode> stack = new Stack<TreeNode>();

            // If the root is null, return the empty result list
            if (root == null) return result;

            // Push the root node onto the stack to start traversal
            stack.Push(root);

            // Continue traversal while the stack is not empty
            while (stack.Count > 0)
            {
                // Pop the top node from the stack
                TreeNode node = stack.Pop();

                // Insert the value of the current node at the beginning of the result list
                // This is done to achieve the reverse order of postorder traversal
                result.Insert(0, node.val); // Insert at the beginning for postorder traversal

                // Push the right child onto the stack first (if exists)
                // This ensures that the right subtree is processed before the left subtree
                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                // Push the left child onto the stack (if exists)
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }

            return result;
        }
    }
}