using System;

namespace DSImplementation.Tree.Implementation.LinkedList
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
    }

    public class BinaryTree
    {
        public TreeNode RootNode { get; set; }

        public TreeNode CreateIterative(int[] input)
        {
            TreeNode rootNode = new TreeNode();

            for (int i = 0; i < input.Length; i++)
            {
                Insert(rootNode, input[i]);
            }

            return rootNode;
        }

        public TreeNode CreateRecursive(int[] input)
        {
            TreeNode rootNode = new TreeNode();
            return rootNode;
        }

        private static void Insert(TreeNode rootNode, int item)
        {
            TreeNode current = null;
            TreeNode parent = null;

            TreeNode newNode = new TreeNode()
            {
                Data = item,
                LeftNode = null,
                RightNode = null
            };

            if (rootNode == null)
            {
                rootNode = newNode;
            }
            else {
                current = rootNode;

                while (true)
                {
                    parent = current;

                    if (rootNode.LeftNode == null)
                    {
                        rootNode.LeftNode = newNode;
                    }
                    else if (rootNode.RightNode == null)
                    {
                        rootNode.RightNode = newNode;
                    }
                    else {
                        rootNode = rootNode.LeftNode;
                    }
                }
            }
        }
    }
}
