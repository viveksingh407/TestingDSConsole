using System;
using DSImplementation.Tree.Traversal;

namespace DSI.Tree.Implementation.Array
{
    public class BinaryTree
    {
        public BinaryTree()
        {
        }

        public int[] Tree { get; set; }
        public int DefaultLeafData { get; set; }

        public void Create(int index, int item)
        {
            this.Tree[index] = item;
            this.Tree[2*index +1] = this.DefaultLeafData;
            this.Tree[2* index + 2] = this.DefaultLeafData;
        }

        public void Traverse()
        {
            DepthFirstTraversal dft = new DepthFirstTraversal();
            dft.DefaultData = this.DefaultLeafData;
            dft.Traverse(this.Tree);
        }
    }
}
