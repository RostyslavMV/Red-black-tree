using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeAlgorithms
{
    class RedBlackTree<T>
    {
        public RedBlackTreeNode<T> Root { get; private set; }

        public RedBlackTree()
        {
            Root = null;
        }
    }
}
