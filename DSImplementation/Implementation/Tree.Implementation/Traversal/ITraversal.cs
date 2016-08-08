using System;
using DSImplementation.Tree.Implementation;

namespace DSImplementation.Tree.Traversal
{
    public interface ITraversal
    {
        void Traverse<T>(TreeTraversalType traversalType, T[] tree);
        void Traverse<T>(TreeTraversalType traversalType, T tree);
        void PrintNode(int index, int item);
    }
}
