using System;
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
            TraverseWithRecursion(tree, 0, 0);
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
