//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RedBlackTreeAlgorithms
//{
//    class RedBlackTreeNodeDuplicate<T>
//    {
//        public T Value { get; set; }
//        public NodeColor Color { get; set; }
//        public RedBlackTreeNodeDuplicate<T> Parrent { get; set; }
//        public RedBlackTreeNodeDuplicate<T> Left { get; set; }
//        public RedBlackTreeNodeDuplicate<T> Right { get; set; }

//        public RedBlackTreeNodeDuplicate(T value)
//        {
//            this.Value = value;
//            Left = null;
//            Right = null;
//            Parrent = null;
//        }
//        public RedBlackTreeNodeDuplicate(T value, RedBlackTreeNodeDuplicate<T> parrentNode)
//        {
//            this.Value = value;
//            Left = null;
//            Right = null;
//            Parrent = parrentNode;
//        }
//        public void SetLeftRightParrent(RedBlackTreeNodeDuplicate<T> leftNode, RedBlackTreeNodeDuplicate<T> rightNode, 
//            RedBlackTreeNodeDuplicate<T> parrentNode)
//        {
//            Left = leftNode;
//            Right = rightNode;
//            Parrent = parrentNode;
//        }
//    }
//}
