using System;
using DSImplementation.Tree.Implementation;
using System.Collections.Generic;
using DSImplementation.Tree.Implementation.LinkedList;
using DSImplementation.Queue.Implementation.LinkedList;
using DSImplementation.Stack.Implementation.LinkedList;

namespace DSImplementation.Tree.Traversal.LinkedList
{
    public class IterativeLinkedListTreeTraversal : ITraversal
    {
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
            MyStack<TreeNode> stack = new MyStack<TreeNode>();

            while (true)
            {
                if (rootNode != null)
                {
                    stack.Push(rootNode);
                    rootNode = rootNode.LeftNode;
                }
                else
                {
                    if (stack.IsStackEmpty())
                        break;

                    rootNode = stack.Pop();
                    Console.Write(rootNode.Data + " ");
                    rootNode = rootNode.RightNode;
                }
            }
        }

        private void PreOrderTraversal<T>(TreeNode rootNode)
        {
            MyStack<TreeNode> stack = new MyStack<TreeNode>();

            while (true)
            {
                if (rootNode != null)
                {
                    stack.Push(rootNode);
                    Console.Write(rootNode.Data + " ");
                    rootNode = rootNode.LeftNode;
                }
                else
                {
                    if (stack.IsStackEmpty())
                        break;

                    rootNode = stack.Pop();
                    rootNode = rootNode.RightNode;
                }
            }
        }

        private void PostOrderTraversal<T>(TreeNode rootNode)
        {
            MyStack<TreeNode> stack1 = new MyStack<TreeNode>();
            MyStack<TreeNode> stack2 = new MyStack<TreeNode>();
            TreeNode temp;
            stack1.Push(rootNode);

            while (!stack1.IsStackEmpty())
            {
                rootNode = stack1.Pop();
                stack2.Push(rootNode);

                if (rootNode.LeftNode != null)
                {
                    stack1.Push(rootNode.LeftNode);
                }

                if (rootNode.RightNode != null)
                {
                    stack1.Push(rootNode.RightNode);
                }
            }

            while (!stack2.IsStackEmpty())
            {
                temp = stack2.Pop();
                Console.Write(temp.Data + " ");
            }
        }

        public void PrintNode(int index, int item)
        {
        }
    }
}
