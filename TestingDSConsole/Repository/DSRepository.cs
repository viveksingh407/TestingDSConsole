using System;
using DSImplementation;
using DSImplementation.Sort;
using DSImplementation.Stack.Implementation.Array;
using aq = DSImplementation.Queue.Implementation.Array;
using lq = DSImplementation.Queue.Implementation.LinkedList;
using DSImplementation.Tree;
using DSImplementation.Tree.Implementation.LinkedList;

namespace TestingDSConsole.Repository
{
    public class DSRepository
    {
        public void Samples()
        {
            //TestStack();
            TestQueue();
            TestQueueByLinkedList();
            //TestTree();
            //TestLinkedListTree();
        }

        private void TestQueueByLinkedList()
        {
            lq.MyQueue<int> st = new lq.MyQueue<int>();

            st.Enqueue(5);
            st.Enqueue(6);

            Console.WriteLine(st.Dequeue());
            Console.WriteLine(st.Dequeue());
        }

        private void TestQueue()
        {
            aq.MyQueue<int> st = new aq.MyQueue<int>(10, true);

            st.Enqueue(5);
            st.Enqueue(6);

            st.Dequeue();
            st.Dequeue();
        }

        private void TestLinkedListTree()
        {
            Tree tree = new Tree();
            TreeTraversal treeTraversal = new TreeTraversal();

            var input = Utility.GetInputData(10);
            var output = tree.CreateTreeByLinkedList(input);

            Utility.PrintFiltered(input);

            treeTraversal.Traverse<TreeNode>(TreeIterationType.Iterative, TreeTraversalType.InOrder, output);
            //treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.InOrder, output);

            //Console.WriteLine();

            //treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PreOrder, output);
            //treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PreOrder, output);

            //Console.WriteLine();

            //treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PostOrder, output);
            //treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PostOrder, output);
        }

        private void TestTree()
        {
            Tree tree = new Tree();
            SelectionSort sort = new SelectionSort();
            TreeTraversal treeTraversal = new TreeTraversal();

            var input = Utility.GetInputData(10);
            var output = tree.CreateTreeByArray(input);

            Utility.PrintFiltered(input);

            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.InOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.InOrder, output);

            Console.WriteLine();

            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PreOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PreOrder, output);

            Console.WriteLine();

            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PostOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PostOrder, output);
        }

        private void TestStack()
        {
            MyStack st = new MyStack(10, true);

            st.Push(5);
            st.Push(6);

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }

        //private void BinaryTreeLinkedListImplementation()
        //{
        //    ls.BinaryTree bTree = new ls.BinaryTree();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        bTree.Create(i+ 1);
        //    }
        //}

        //private void BinaryTreeArrayImplementation()
        //{
        //    var treeNodes = 10;

        //    ar.BinaryTree tr = new ar.BinaryTree();
        //    tr.DefaultLeafData = -999;

        //    tr.Tree = new int[2 * treeNodes + 2];

        //    for (int i = 0; i < treeNodes; i++)
        //    {
        //        tr.Create(i, i + 1);
        //    }

        //    tr.Traverse();
        //}
    }
}
