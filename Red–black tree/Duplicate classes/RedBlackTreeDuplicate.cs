using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTree
{
    class RedBlackTreeDuplicate<TValue>
    {
        public RedBlackTreeNodeDuplicate<TValue> Root { get; set; }

        public RedBlackTreeDuplicate()
        {
            Root = null;
        }

        public static RedBlackTreeDuplicate<int> makeExampleTree()
        {
            RedBlackTreeDuplicate<int> tree = new RedBlackTreeDuplicate<int>();
            tree.Root = new RedBlackTreeNodeDuplicate<int>(10);
            tree.Root.color = RedBlackTreeNodeDuplicate<int>.Color.Black;
            RedBlackTreeNodeDuplicate<int> node1 = new RedBlackTreeNodeDuplicate<int>(1);
            node1.color = RedBlackTreeNodeDuplicate<int>.Color.Red;
            RedBlackTreeNodeDuplicate<int> node2 = new RedBlackTreeNodeDuplicate<int>(2);
            node2.color = RedBlackTreeNodeDuplicate<int>.Color.Black;
            RedBlackTreeNodeDuplicate<int> node3 = new RedBlackTreeNodeDuplicate<int>(3);
            node3.color = RedBlackTreeNodeDuplicate<int>.Color.Red;
            RedBlackTreeNodeDuplicate<int> node4 = new RedBlackTreeNodeDuplicate<int>(4);
            node4.color = RedBlackTreeNodeDuplicate<int>.Color.Black;
            RedBlackTreeNodeDuplicate<int> node5 = new RedBlackTreeNodeDuplicate<int>(5);
            node5.color = RedBlackTreeNodeDuplicate<int>.Color.Red;
            RedBlackTreeNodeDuplicate<int> node6 = new RedBlackTreeNodeDuplicate<int>(6);
            node6.color = RedBlackTreeNodeDuplicate<int>.Color.Black;
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
