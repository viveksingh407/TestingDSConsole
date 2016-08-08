using System;

namespace DSImplementation.Tree.Implementation.LinkedList
{
    public class BinaryTree
    {
        //private Queue _queue;

        public class Queue
        {
            public TreeNode Node { get; set; }
            public Queue Next { get; set; }
            public Queue Front { get; set; }
            public Queue Rear { get; set; }
        }

        public class TreeNode
        {
            public int Data { get; set; }
            public TreeNode LeftNode { get; set; }
            public TreeNode RightNode { get; set; }
        }
        public void Create(int item)
        {
            
        }

        public void Enqueue()
        {
            //if(_queue == null)
            //{

            //}
        }

        public void Dequeue()
        {
        }
    }
}
