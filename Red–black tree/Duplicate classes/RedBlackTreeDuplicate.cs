using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeAlgorithms
{
    class RedBlackTreeDuplicate<T>
    {
        public RedBlackTreeNodeDuplicate<T> Root { get; set; }

        public RedBlackTreeDuplicate()
        {
            Root = null;
        }

        public static RedBlackTreeDuplicate<int> MakeExampleTree()
        {
            RedBlackTreeDuplicate<int> tree = new RedBlackTreeDuplicate<int>
            {
                Root = new RedBlackTreeNodeDuplicate<int>(10)
                {
                    Color = NodeColor.Black
                }
            };
            RedBlackTreeNodeDuplicate<int> node1 = new RedBlackTreeNodeDuplicate<int>(1)
            {
                Color = NodeColor.Red
            };
            RedBlackTreeNodeDuplicate<int> node2 = new RedBlackTreeNodeDuplicate<int>(2)
            {
                Color = NodeColor.Black
            };
            RedBlackTreeNodeDuplicate<int> node3 = new RedBlackTreeNodeDuplicate<int>(3)
            {
                Color = NodeColor.Red
            };
            RedBlackTreeNodeDuplicate<int> node4 = new RedBlackTreeNodeDuplicate<int>(4)
            {
                Color = NodeColor.Black
            };
            RedBlackTreeNodeDuplicate<int> node5 = new RedBlackTreeNodeDuplicate<int>(5)
            {
                Color = NodeColor.Red
            };
            RedBlackTreeNodeDuplicate<int> node6 = new RedBlackTreeNodeDuplicate<int>(6)
            {
                Color = NodeColor.Black
            };
            tree.Root.SetLeftRightParrent(node1, node2, null);
            node1.SetLeftRightParrent(node3,node4,tree.Root);
            node2.SetLeftRightParrent(null,node5,tree.Root);
            node3.SetLeftRightParrent(null,null,node1);
            node4.SetLeftRightParrent(node6,null,node1);
            node5.SetLeftRightParrent(null,null,node2);
            node6.SetLeftRightParrent(null,null,node4);
            return tree;
        }
    }
}
