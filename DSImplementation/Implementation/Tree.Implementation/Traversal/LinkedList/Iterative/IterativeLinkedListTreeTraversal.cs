using System;
using DSImplementation.Tree.Implementation;
using System.Collections.Generic;
using DSImplementation.Tree.Implementation.LinkedList;
using DSImplementation.Queue.Implementation.LinkedList;

namespace DSImplementation.Tree.Traversal.LinkedList
{
    public class IterativeLinkedListTreeTraversal : ITraversal
    {
        private static int _count = 1;

        public void Traverse<T>(TreeTraversalType traversalType, T[] tree)
        {
        }

        public void Traverse<T>(TreeTraversalType traversalType, T tree)
        {
            switch (traversalType)
            {
                case TreeTraversalType.InOrder:
                    Console.Write("InOrder Traversal: ");
                    InOrderTraversal(tree);
                    break;
                case TreeTraversalType.PreOrder:
                    Console.Write("PreOrder Traversal: ");
                    PreOrderTraversal(tree);
                    break;
                case TreeTraversalType.PostOrder:
                    Console.Write("PostOrder Traversal: ");
                    PostOrderTraversal(tree);
                    break;
                default:
                    Console.Write("Default InOrder Traversal: ");
                    InOrderTraversal(tree);
                    break;
            }

            Console.WriteLine();
        }

        private void InOrderTraversal<T>(T rootNode)
        {
            //MyQueue<T> queue = new MyQueue<T>(10, );
            //while()
        }

        private void PreOrderTraversal<T>(T rootNode)
        { }

        private void PostOrderTraversal<T>(T rootNode)
        { }

        public void PrintNode(int index, int item)
        {
            Console.WriteLine("Count: {0}, Index: {1}, Data: {2}", _count, index, item);
            _count += 1;
        }
    }
}
