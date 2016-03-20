using System;
using ar = DSI.Tree.Implementation.Array;
using ls = DSI.Tree.Implementation.LinkedList;

namespace TestingDSConsole.Repository
{
    public class DSRepository
    {
        public void Samples()
        {
            //BinaryTreeArrayImplementation();
            BinaryTreeLinkedListImplementation();
        }

        private void BinaryTreeLinkedListImplementation()
        {
            ls.BinaryTree bTree = new ls.BinaryTree();
            for (int i = 0; i < 10; i++)
            {
                bTree.Create(i+ 1);
            }
        }

        private void BinaryTreeArrayImplementation()
        {
            var treeNodes = 10;

            ar.BinaryTree tr = new ar.BinaryTree();
            tr.DefaultLeafData = -999;

            tr.Tree = new int[2 * treeNodes + 2];

            for (int i = 0; i < treeNodes; i++)
            {
                tr.Create(i, i + 1);
            }

            tr.Traverse();
        }
    }
}
