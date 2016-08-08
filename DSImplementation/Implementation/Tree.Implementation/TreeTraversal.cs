using System;
using DSImplementation.Tree.Implementation;
using DSImplementation.Tree.Traversal;
using DSImplementation.Tree.Traversal.Array;
using DSImplementation.Tree.Traversal.LinkedList;
using DSImplementation.Tree.Implementation.Array;
using DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Tree
{
    public enum TreeTraversalType
    {
        PreOrder,
        InOrder,
        PostOrder,
        BreadthFirstOrder,
    }

    public class TreeTraversal
    {
        public void Traverse<T>(T[] input)
        {
            this.Traverse<T>(TreeIterationType.Iterative, TreeTraversalType.InOrder, input);
        }

        public void Traverse<T>(TreeIterationType iterationType, TreeTraversalType traversalType, T[] input)
        {
            ITraversal traversal = null;

            if (iterationType == TreeIterationType.Iterative)
            {
                traversal = new IterativeArrayTraversal();
                traversal.Traverse<T>(traversalType, input);
            }
            else
            {
                traversal = new RecursiveArrayTraversal();
                traversal.Traverse<T>(traversalType, input);
            }
        }

        public void Traverse<T>(TreeIterationType iterationType, TreeTraversalType traversalType, T input)
        {
            ITraversal traversal = null;

            if (iterationType == TreeIterationType.Iterative)
            {
                traversal = new IterativeLinkedListTreeTraversal();
                traversal.Traverse<T>(traversalType, input);
            }
            else
            {
                traversal = new RecursiveLinkedListTreeTraversal();
                traversal.Traverse<T>(traversalType, input);
            }
        }
    }
}
