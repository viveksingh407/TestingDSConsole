using System;
using DSImplementation.Tree.Implementation;
using DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Tree.Traversal
{
    public interface ITraversal
    {
        void Traverse<T>(TreeTraversalType traversalType, T[] tree);
        void Traverse<T>(TreeTraversalType traversalType, TreeNode tree);
        void PrintNode(int index, int item);
    }
}
