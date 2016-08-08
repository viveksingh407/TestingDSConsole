﻿using System;
using DSImplementation.Tree.Implementation;

namespace DSImplementation.Tree.Traversal.Array
{
    public class RecursiveArrayTraversal : ITraversal
    {
        public RecursiveArrayTraversal()
        {
        }

        private static int _count = 1;
        public int DefaultData { get; set; }

        public void Traverse(TreeTraversalType traversalType, int[] tree)
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
                default:
                    Console.Write("Default InOrder Traversal: ");
                    InOrderTraversal(tree, 0);
                    break;
            }

            Console.WriteLine();
        }

        private void InOrderTraversal(int[] input, int currentIndex)
        {
            if (input[currentIndex] == -999)
                return;

            var leftIndex = 2 * currentIndex + 1;
            var rightIndex = 2 * currentIndex + 2;

            InOrderTraversal(input, leftIndex);
            Console.Write(input[currentIndex] + " ");
            InOrderTraversal(input, rightIndex);
        }

        private void PreOrderTraversal(int[] input, int currentIndex)
        {
            if (input[currentIndex] == -999)
                return;

            var leftIndex = 2 * currentIndex + 1;
            var rightIndex = 2 * currentIndex + 2;

            Console.Write(input[currentIndex] + " ");
            PreOrderTraversal(input, leftIndex);
            PreOrderTraversal(input, rightIndex);
        }

        private void PostOrderTraversal(int[] input, int currentIndex)
        {
            if (input[currentIndex] == -999)
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

        public void PrintNode(int index, int item)
        {
            Console.WriteLine("Count: {0}, Index: {1}, Data: {2}", _count, index, item);
            _count += 1;
        }
    }
}