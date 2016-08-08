using System;
using DSImplementation.Tree.Traversal.Array;

namespace DSImplementation.Tree.Implementation.Array
{
    public class BinaryTree
    {
        public BinaryTree()
        {
        }

        public int[] _tree;

        public int[] CreateIterative(int[] input)
        {
            int treeSize = 2 * input.Length + 2;
            _tree = new int[treeSize];

            for (int i = 0; i < input.Length; i++)
            {
                this.Create(i, input[i]);
            }

            return _tree;
        }

        public int[] CreateRecursive(int[] input)
        {
            int treeSize = 2 * input.Length + 2;
            _tree = new int[treeSize];

            this.CreateRecursiveTree(0, input);

            return _tree;
        }

        private void CreateRecursiveTree(int index, int[] input)
        {
            if(index == input.Length - 1)
            {
                return;
            }

            Create(index, input[index]);
            CreateRecursiveTree(index + 1, input);
        }

        private void Create(int index, int item)
        {
            _tree[2 * index + 1] = 0;
            _tree[2 * index + 2] = 0;
            _tree[index] = item;
        }
    }
}
