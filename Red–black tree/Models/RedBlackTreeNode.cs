using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTree
{
    class RedBlackTreeNode<TValue>
    {
        public enum Color
        {
            Red,
            Black
        };
        public TValue value { get; private set; }
        public Color color { get; private set; }
        public RedBlackTreeNode<TValue> parrent { get; private set; }
        public RedBlackTreeNode<TValue> left { get; private set; }
        public RedBlackTreeNode<TValue> right { get; private set; }

        RedBlackTreeNode(TValue value)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = null;
        }
        RedBlackTreeNode(TValue value, RedBlackTreeNode<TValue> parrentNode)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = parrentNode;
        }
    }
}
