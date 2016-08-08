using System;
using DSImplementation.Tree.Implementation;
using DSImplementation.Tree.Traversal.Array;
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
        public void Traverse(int[] input)
        {
            this.Traverse(TreeImplementationType.Array, TreeIterationType.Iterative, TreeTraversalType.InOrder, input);
        }

        public void Traverse(TreeImplementationType implementationType, TreeIterationType iterationType, TreeTraversalType traversalType, int[] input)
        {
            ITraversal traversal = null;

            if (implementationType == TreeImplementationType.Array)
            {
                if (iterationType == TreeIterationType.Iterative)
                {
                    traversal = new IterativeArrayTraversal();
                    traversal.Traverse(traversalType, input);
                }
                else
                {
                    traversal = new RecursiveArrayTraversal();
                    traversal.Traverse(traversalType, input);
                }
            }
            else
            {
                //if (this.TreeImplementationType == TreeImplementationType.Array)
                //{
                //    if (this.TreeIterationType == TreeIterationType.Iterative)
                //    {
                //        dfs = new DepthFirstIterativeArrayTraversal();
                //    }
                //    else
                //    {
                //        dfs = new DepthFirstRecursiveArrayTraversal();
                //    }
                //}
            }
        }
    }
}
