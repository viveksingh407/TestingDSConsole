﻿using System;
using DSImplementation.Tree.Traversal.Array;
using ar = DSImplementation.Tree.Implementation.Array;
using list = DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Tree
{
    public enum TreeImplementationType {
        Array,
        LinkedList
    }

    public enum TreeIterationType {
        Iterative,
        Recursive
    }

    public class Tree
    {
        public int[] CreateTreeByArray(int[] input)
        {
            return Create(TreeIterationType.Iterative, input);
        }

        public list.TreeNode CreateTreeByLinkedList(int[] input)
        {
            return CreateTreeByLinkedList(TreeIterationType.Iterative, input);
        }

        public int[] Create(TreeIterationType iterationType, int[] input)
        {
            ar.BinaryTree tree = new ar.BinaryTree();
            int[] output = null;

            if (iterationType == TreeIterationType.Iterative)
            {
                output = tree.CreateIterative(input);
            }
            else
            {
                output = tree.CreateRecursive(input);
            }

            return output;
        }

        public list.TreeNode CreateTreeByLinkedList(TreeIterationType iterationType, int[] input)
        {
            list.BinaryTree tree = new list.BinaryTree();
            list.TreeNode output = null;

            if (iterationType == TreeIterationType.Iterative)
            {
                output = tree.CreateIterative(input);
            }
            else
            {
                output = tree.CreateRecursive(input);
            }

            return output;
        }
    }
}



