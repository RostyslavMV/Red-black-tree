using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTree
{
    class RedBlackTreeNodeDuplicate<TValue>
    {
        public enum Color
        {
            Red,
            Black
        };
        public TValue value { get; set; }
        public Color color { get; set; }
        public RedBlackTreeNodeDuplicate<TValue> parrent { get; set; }
        public RedBlackTreeNodeDuplicate<TValue> left { get; set; }
        public RedBlackTreeNodeDuplicate<TValue> right { get; set; }

        public RedBlackTreeNodeDuplicate(TValue value)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = null;
        }
        public RedBlackTreeNodeDuplicate(TValue value, RedBlackTreeNodeDuplicate<TValue> parrentNode)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = parrentNode;
        }
        public void SetLeftRightParrent(RedBlackTreeNodeDuplicate<TValue> leftNode, RedBlackTreeNodeDuplicate<TValue> rightNode, 
            RedBlackTreeNodeDuplicate<TValue> parrentNode)
        {
            left = leftNode;
            right = rightNode;
            parrent = parrentNode;
        }
    }
}
