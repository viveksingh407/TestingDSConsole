using System;

namespace DSImplementation.Tree.Traversal
{
    public class DepthFirstTraversal
    {
        public DepthFirstTraversal()
        {
        }

        private static int _count = 1;

        public int DefaultData { get; set; }

        public void Traverse(int[] tree)
        {
            TraverseWithoutRecursion(tree);
            TraverseWithRecursion(tree);
        }

        public void TraverseWithRecursion(int[] tree)
        {
            _count = 0;
            Console.WriteLine();
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
