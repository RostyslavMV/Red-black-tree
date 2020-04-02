using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeAlgorithms
{
    class RedBlackTreeNodeDuplicate<T>
    {
        public T value { get; set; }
        public Color color { get; set; }
        public RedBlackTreeNodeDuplicate<T> parrent { get; set; }
        public RedBlackTreeNodeDuplicate<T> left { get; set; }
        public RedBlackTreeNodeDuplicate<T> right { get; set; }

        public RedBlackTreeNodeDuplicate(T value)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = null;
        }
        public RedBlackTreeNodeDuplicate(T value, RedBlackTreeNodeDuplicate<T> parrentNode)
        {
            this.value = value;
            left = null;
            right = null;
            parrent = parrentNode;
        }
        public void SetLeftRightParrent(RedBlackTreeNodeDuplicate<T> leftNode, RedBlackTreeNodeDuplicate<T> rightNode, 
            RedBlackTreeNodeDuplicate<T> parrentNode)
        {
            left = leftNode;
            right = rightNode;
            parrent = parrentNode;
        }
    }
}
