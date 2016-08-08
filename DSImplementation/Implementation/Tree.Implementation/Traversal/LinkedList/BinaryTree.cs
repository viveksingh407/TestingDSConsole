using System;
using DSImplementation.Queue.Implementation.Array;

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
        private static MyQueue<TreeNode> _queue;

        public TreeNode RootNode { get; set; }

        public TreeNode CreateIterative(int[] input)
        {
            _queue = new MyQueue<TreeNode>(input.Length, false);
            RootNode = null;

            for (int i = 0; i < input.Length; i++)
            {
                Insert(input[i]);
            }

            return this.RootNode;
        }

        public TreeNode CreateRecursive(int[] input)
        {
            TreeNode rootNode = new TreeNode();
            return rootNode;
        }

        private void Insert(int item)
        {
            TreeNode currentNode = null;

            TreeNode newNode = new TreeNode()
            {
                Data = item,
                LeftNode = null,
                RightNode = null
            };

            if (this.RootNode == null)
            {
                this.RootNode = newNode;
            }
            else
            {
                currentNode = _queue.Peek();

                if (currentNode.LeftNode == null)
                {
                    currentNode.LeftNode = newNode;
                }
                else if (currentNode.RightNode == null)
                {
                    currentNode.RightNode = newNode;
                }
                
                if(currentNode.LeftNode != null && currentNode.RightNode != null)
                {
                    _queue.Dequeue();
                }
            }

            _queue.Enqueue(newNode);
        }
    }
}
