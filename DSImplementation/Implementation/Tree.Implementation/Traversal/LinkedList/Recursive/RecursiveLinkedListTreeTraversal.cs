using System;
using DSImplementation.Tree.Implementation;
using System.Collections.Generic;
using DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Tree.Traversal.LinkedList
{
    public class RecursiveLinkedListTreeTraversal : ITraversal
    {
        private static int _count = 1;

        public void Traverse<T>(TreeTraversalType traversalType, T[] tree)
        {
        }

        public void Traverse<T>(TreeTraversalType traversalType, TreeNode tree)
        {
            switch (traversalType)
            {
                case TreeTraversalType.InOrder:
                    Console.Write("InOrder Traversal: ");
                    InOrderTraversal<T>(tree);
                    break;
                case TreeTraversalType.PreOrder:
                    Console.Write("PreOrder Traversal: ");
                    PreOrderTraversal<T>(tree);
                    break;
                case TreeTraversalType.PostOrder:
                    Console.Write("PostOrder Traversal: ");
                    PostOrderTraversal<T>(tree);
                    break;
                default:
                    Console.Write("Default InOrder Traversal: ");
                    InOrderTraversal<T>(tree);
                    break;
            }

            Console.WriteLine();
        }

        private void InOrderTraversal<T>(TreeNode rootNode)
        {
            if (rootNode == null)
                return;

            InOrderTraversal<T>(rootNode.LeftNode);
            Console.Write(rootNode.Data + " ");
            InOrderTraversal<T>(rootNode.RightNode);
        }

        private void PreOrderTraversal<T>(TreeNode rootNode)
        {
            if (rootNode == null)
                return;

            Console.Write(rootNode.Data + " ");
            PreOrderTraversal<T>(rootNode.LeftNode);
            PreOrderTraversal<T>(rootNode.RightNode);
        }

        private void PostOrderTraversal<T>(TreeNode rootNode)
        {
            if (rootNode == null)
                return;

            PostOrderTraversal<T>(rootNode.LeftNode);
            PostOrderTraversal<T>(rootNode.RightNode);
            Console.Write(rootNode.Data + " ");
        }

        public void PrintNode(int index, int item)
        {
            Console.WriteLine("Count: {0}, Index: {1}, Data: {2}", _count, index, item);
            _count += 1;
        }
    }
}
