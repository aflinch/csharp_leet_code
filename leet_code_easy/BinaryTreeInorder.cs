using System.Collections.Generic;

// Given the root of a binary tree, return the inorder traversal of its nodes' values.

namespace leet_code_easy
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class BinaryTreeInorder
    {
        public static IList<int> InorderTraversal(TreeNode root) {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result.ToArray();
        }
    }
}