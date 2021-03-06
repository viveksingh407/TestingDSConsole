﻿using System;
using DSImplementation.Tree.Implementation;
using System.Collections.Generic;
using DSImplementation.Tree.Implementation.LinkedList;
using DSImplementation.Queue.Implementation.Array;

namespace DSImplementation.Tree.Traversal.Array
{
    public class RecursiveArrayTraversal : ITraversal
    {
        public RecursiveArrayTraversal()
        {
        }

        private static int _count = 1;
        public int DefaultData { get; set; }

        public void Traverse<T>(TreeTraversalType traversalType, TreeNode tree)
        {
        }

        public void Traverse<T>(TreeTraversalType traversalType, T[] tree)
        {
            switch (traversalType)
            {
                case TreeTraversalType.InOrder:
                    Console.Write("InOrder Traversal: ");
                    InOrderTraversal(tree, 0);
                    break;
                case TreeTraversalType.PreOrder:
                    Console.Write("PreOrder Traversal: ");
                    PreOrderTraversal(tree, 0);
                    break;
                case TreeTraversalType.PostOrder:
                    Console.Write("PostOrder Traversal: ");
                    PostOrderTraversal(tree, 0);
                    break;
                case TreeTraversalType.BreadthFirstOrder:
                    Console.Write("LevelOrder Traversal: ");
                    BreadthFirstOrderTraversal<T>(tree);
                    break;
                default:
                    Console.Write("Default InOrder Traversal: ");
                    InOrderTraversal(tree, 0);
                    break;
            }

            Console.WriteLine();
        }

        private void InOrderTraversal<T>(T[] input, int currentIndex)
        {
            if (EqualityComparer<T>.Default.Equals(input[currentIndex], default(T)))
                return;

            var leftIndex = 2 * currentIndex + 1;
            var rightIndex = 2 * currentIndex + 2;

            InOrderTraversal(input, leftIndex);
            Console.Write(input[currentIndex] + " ");
            InOrderTraversal(input, rightIndex);
        }

        private void PreOrderTraversal<T>(T[] input, int currentIndex)
        {
            if (EqualityComparer<T>.Default.Equals(input[currentIndex], default(T)))
                return;

            var leftIndex = 2 * currentIndex + 1;
            var rightIndex = 2 * currentIndex + 2;

            Console.Write(input[currentIndex] + " ");
            PreOrderTraversal(input, leftIndex);
            PreOrderTraversal(input, rightIndex);
        }

        private void PostOrderTraversal<T>(T[] input, int currentIndex)
        {
            if (EqualityComparer<T>.Default.Equals(input[currentIndex], default(T)))
                return;

            var leftIndex = 2 * currentIndex + 1;
            var rightIndex = 2 * currentIndex + 2;

            PostOrderTraversal(input, leftIndex);
            PostOrderTraversal(input, rightIndex);
            Console.Write(input[currentIndex] + " ");
        }

        public void TraverseWithRecursion(int[] tree, int previousIndex, int index)
        {
            if (previousIndex <= index)
            {
                if (tree[2 * index + 1] != this.DefaultData)
                {
                    TraverseWithRecursion(tree, index, 2 * index + 1);
                }
            }
            else
            {
                PrintNode(index, tree[index]);
                if (tree[2 * index + 2] != this.DefaultData)
                {
                    TraverseWithRecursion(tree, index, 2 * index + 2);
                }
            }
        }

        public void BreadthFirstOrderTraversal<T>(T[] input)
        {
            if (input != null)
            {
                MyQueue<T> queue = new MyQueue<T>(input.Length, false);

                dynamic a = 0;

                queue.Enqueue(a);

                BFS<T>(input, 0, queue);
            }
        }

        private void BFS<T>(T[] input, int currentIndex, MyQueue<T> queue)
        {
            if (queue.isQueueEmpty())
                return;

            currentIndex = Convert.ToInt32(queue.Dequeue());

            Console.Write(input[currentIndex] + " ");

            dynamic a = 2;
            var leftNode = a * currentIndex + 1;
            var rightIndex = a * currentIndex + 2;

            if (!EqualityComparer<T>.Default.Equals(input[leftNode], default(T)))
            {
                queue.Enqueue(leftNode);
            }

            if (!EqualityComparer<T>.Default.Equals(input[rightIndex], default(T)))
            {
                queue.Enqueue(rightIndex);
            }

            BFS(input, currentIndex, queue);
        }

        public void PrintNode(int index, int item)
        {
            Console.WriteLine("Count: {0}, Index: {1}, Data: {2}", _count, index, item);
            _count += 1;
        }
    }
}
