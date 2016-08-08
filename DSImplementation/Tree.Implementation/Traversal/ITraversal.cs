using System;
using DSImplementation.Tree.Implementation;

namespace DSImplementation.Tree.Traversal.Array
{
    public interface ITraversal
    {
        void Traverse(TreeTraversalType traversalType, int[] tree);
        void PrintNode(int index, int item);
    }
}
