using System;
using DSImplementation;
using DSImplementation.Sort;
using DSImplementation.LinkedList.Implementation;
using DSImplementation.Stack.Implementation.Array;
using DSImplementation.Stack.Implementation.LinkedList;
using aq = DSImplementation.Queue.Implementation.Array;
using lq = DSImplementation.Queue.Implementation.LinkedList;
using DSImplementation.Tree;
using DSImplementation.Tree.Implementation.LinkedList;
using DSImplementation.Strings;

namespace TestingDSConsole.Repository
{
    public class DSRepository
    {
        public void Samples()
        {
            //TestLinkedList();
            //TestStack();
            //TestStackByLinkedList();
            //TestQueue();
            //TestQueueByLinkedList();

            //var input = Utility.GetInputData(10);

            //TestTree(input);
            //Console.WriteLine();
            //Console.WriteLine("Linked List: ");
            //TestLinkedListTree(input);

            TestStringProblems();
        }

        private void TestStringProblems()
        {

            Problems stringProblems = new Problems();
            stringProblems.MatchPatternNaiveImplementation();
        }

        private void TestLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            int[] input = Utility.GetInputData(10);

            Utility.PrintAll(input);

            for (int i = 0; i < input.Length; i++)
            {
                list.InsertFirstNode(input[i]);
            }

            Console.Write("Output: ");
            list.Traverse();

            Console.Write("Insert last node: ");
            list.InsertLastNode(5);
            list.Traverse();

            Console.Write("Insert 5th node: ");
            list.InsertNthNode(6, 5);
            list.Traverse();

            Console.Write("Insert 5th node from last: ");
            list.InsertNthFromLastNode(229, 5);
            list.Traverse();

            Console.Write("Delete first node: ");
            list.DeleteFirstNode();
            list.Traverse();

            Console.Write("Delete last node: ");
            list.DeleteLastNode();
            list.Traverse();

            Console.Write("Delete 7th node: ");
            list.DeleteNthNode(7);
            list.Traverse();

            Console.Write("Delete 8th from last node: ");
            list.DeleteNthFromLastNode(8);
            list.Traverse();
        }

        private void TestStackByLinkedList()
        {
            MyStack<int> st = new MyStack<int>();

            st.Push(5);
            st.Push(6);

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
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

        private void TestTree(int[] input)
        {
            Tree tree = new Tree();
            SelectionSort sort = new SelectionSort();
            TreeTraversal treeTraversal = new TreeTraversal();

            var output = tree.CreateTreeByArray(input);

            Utility.PrintFiltered(input);

            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.InOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.InOrder, output);
            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PreOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PreOrder, output);
            treeTraversal.Traverse(TreeIterationType.Iterative, TreeTraversalType.PostOrder, output);
            treeTraversal.Traverse(TreeIterationType.Recursive, TreeTraversalType.PostOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Iterative, TreeTraversalType.BreadthFirstOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Recursive, TreeTraversalType.BreadthFirstOrder, output);
        }

        private void TestLinkedListTree(int[] input)
        {
            Tree tree = new Tree();
            TreeTraversal treeTraversal = new TreeTraversal();

            var output = tree.CreateTreeByLinkedList(input);

            Utility.PrintFiltered(input);

            treeTraversal.Traverse<int>(TreeIterationType.Iterative, TreeTraversalType.InOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Recursive, TreeTraversalType.InOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Iterative, TreeTraversalType.PreOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Recursive, TreeTraversalType.PreOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Iterative, TreeTraversalType.PostOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Recursive, TreeTraversalType.PostOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Iterative, TreeTraversalType.BreadthFirstOrder, output);
            treeTraversal.Traverse<int>(TreeIterationType.Recursive, TreeTraversalType.BreadthFirstOrder, output);
        }

        private void TestStack()
        {
            MyStack st = new MyStack(10, false);

            st.Push(5);
            st.Push(6);

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
    }
}
