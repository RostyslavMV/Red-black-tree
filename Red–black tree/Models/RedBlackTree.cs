using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTree
{
    class RedBlackTree<TValue>
    {
        public RedBlackTreeNode<TValue> Root { get; private set; }

        public RedBlackTree()
        {
            Root = null;
        }
    }
}
