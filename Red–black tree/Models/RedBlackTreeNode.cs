using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeAlgorithms
{
    class RedBlackTreeNode<T>
    {
        public T value { get; private set; }
        public Color color { get; private set; }                                                   
        public RedBlackTreeNode<T> parrent { get; private set; }                              
        public RedBlackTreeNode<T> left { get; private set; }                                 
        public RedBlackTreeNode<T> right { get; private set; }                                
                                                                                                   
        RedBlackTreeNode(T value)                                                             
        {                                                                                          
            this.value = value;                                                                    
            left = null;                                                                           
            right = null;                                                                          
            parrent = null;                                                                        
        }                                                                                          
        RedBlackTreeNode(T value, RedBlackTreeNode<T> parrentNode)                       
        {                                                                                          
            this.value = value;                                                                    
            left = null;
            right = null;
            parrent = parrentNode;
        }
    }
}
