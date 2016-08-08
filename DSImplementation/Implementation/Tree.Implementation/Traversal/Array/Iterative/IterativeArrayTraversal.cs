using System;
using System.Linq;
using System.Collections.Generic;
using DSImplementation.Stack.Implementation.Array;
using DSImplementation.Tree.Implementation;

namespace DSImplementation.Tree.Traversal.Array
{
    public class IterativeArrayTraversal : ITraversal
    {
        public IterativeArrayTraversal()
        {
        }

        private static int _count = 1;

        public int DefaultData { get; set; }

        public void Traverse(TreeTraversalType traversalType, int[] tree)
        {
            //TraverseWithoutRecursion(tree);
            switch(traversalType)
            {
                case TreeTraversalType.InOrder:
                    InOrderTraversal(tree);
                    break;
                case TreeTraversalType.PreOrder:
                    PreOrderTraversal(tree);
                    break;
                case TreeTraversalType.PostOrder:
                    PostOrderTraversal(tree);
                    break;
                default:
                    InOrderTraversal(tree);
                    break;
            }

            Console.WriteLine();
        }

        private void InOrderTraversal(int[] input)
        {
            var currentIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;
            var done = false;

            if (input == null || input.Length == 0)
                return;

            MyStack st = new MyStack(input.Length, false);

            Console.Write("InOrder Traversal: ");

            while (!done)
            {
                if (input[currentIndex] != -999)
                {
                    st.Push(currentIndex);
                    leftIndex = 2 * currentIndex + 1;
                    currentIndex = leftIndex;
                }
                else
                {
                    if (!st.isStackEmpty())
                    {
                        currentIndex = st.Pop();
                        rightIndex = 2 * currentIndex + 2;
                        Console.Write(input[currentIndex] + " ");
                        currentIndex = rightIndex;
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
        }

        private void PreOrderTraversal(int[] input)
        {
            var currentIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;
            var done = false;

            if (input == null || input.Length == 0)
                return;

            MyStack st = new MyStack(input.Length, false);

            Console.Write("PreOrder Traversal: ");

            while (!done)
            {
                if (input[currentIndex] != -999)
                {
                    st.Push(currentIndex);
                    Console.Write(input[currentIndex] + " ");
                    leftIndex = 2 * currentIndex + 1;
                    currentIndex = leftIndex;
                }
                else
                {
                    if (!st.isStackEmpty())
                    {
                        currentIndex = st.Pop();
                        rightIndex = 2 * currentIndex + 2;
                        currentIndex = rightIndex;
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
        }

        private void PostOrderTraversal(int[] input)
        {
            var currentIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;

            if (input == null || input.Length == 0)
                return;

            MyStack st1 = new MyStack(input.Length, false);
            MyStack st2 = new MyStack(input.Length, false);

            Console.Write("PostOrder Traversal: ");

            st1.Push(currentIndex);

            while (!st1.isStackEmpty())
            {
                currentIndex = st1.Pop();

                st2.Push(currentIndex);

                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (input[leftIndex] != -999)
                {
                    st1.Push(leftIndex);
                }

                if (input[rightIndex] != -999)
                {
                    st1.Push(rightIndex);
                }
            }

            while(!st2.isStackEmpty())
            {
                Console.Write(input[st2.Pop()] + " ");
            }
        }

        public void TraverseWithoutRecursion(int[] tree)
        {
            var index = 0;
            var previousIndex = 0;
            var tempIndex = 0;

            while (previousIndex >= 0)
            {
                if (previousIndex <= index)
                {
                    if (tree[2 * index + 1] != this.DefaultData)
                    {
                        tempIndex = 2 * index + 1;
                    }
                    else if (tree[2 * index + 2] != this.DefaultData)
                    {
                        tempIndex = 2 * index + 2;
                    }
                    else
                    {
                        PrintNode(index, tree[index]);
                        tempIndex = (index != 0) ? (index - 1) / 2 : -1;
                    }
                }
                else if (previousIndex > index)
                {
                    if (previousIndex % 2 != 0)
                    {
                        PrintNode(index, tree[index]);

                        if (tree[2 * index + 2] != this.DefaultData)
                        {
                            tempIndex = 2 * index + 2;
                        }
                        else
                        {
                            tempIndex = (index != 0) ? (index - 1) / 2 : -1;
                        }
                    }
                    else
                    {
                        tempIndex = (index != 0) ? (index - 1) / 2 : -1;
                    }
                }

                previousIndex = index;
                index = tempIndex;
            }
        }

        public void PrintNode(int index, int item)
        {
            Console.WriteLine("Count: {0}, Index: {1}, Data: {2}", _count, index, item);
            _count += 1;
        }
    }
}
