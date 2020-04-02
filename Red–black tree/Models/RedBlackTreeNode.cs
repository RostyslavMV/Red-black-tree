using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeAlgorithms
{
    class RedBlackTreeNode<T>
    {
        public T Value { get; private set; }
        public NodeColor Color { get; private set; }                                                   
        public RedBlackTreeNode<T> Parrent { get; private set; }                              
        public RedBlackTreeNode<T> Left { get; private set; }                                 
        public RedBlackTreeNode<T> Right { get; private set; }                                
                                                                                                   
        RedBlackTreeNode(T value)                                                             
        {                                                                                          
            this.Value = value;                                                                    
            Left = null;                                                                           
            Right = null;                                                                          
            Parrent = null;                                                                        
        }                                                                                          
        RedBlackTreeNode(T value, RedBlackTreeNode<T> parrentNode)                       
        {                                                                                          
            this.Value = value;                                                                    
            Left = null;
            Right = null;
            Parrent = parrentNode;
        }
    }
}
