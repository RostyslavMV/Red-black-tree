using RedBlackTreeAlgorithms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeVisuals
{
    class RedBlackTreeNodeViewModel<T> : INotifyPropertyChanged
    {
        public RedBlackTreeNodeViewModel(RedBlackTreeNodeDuplicate<T> redBlackTreeNode)
        {
            UpdateNodeProperties(redBlackTreeNode);
        }
        private T value;
        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
            }
        }

        private RedBlackTreeAlgorithms.NodeColor color;
        public RedBlackTreeAlgorithms.NodeColor Color
        {
            get => color;
            set
            {
                color = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }
        private ObservableCollection<RedBlackTreeNodeViewModel<T>> children;
        public ObservableCollection<RedBlackTreeNodeViewModel<T>> Children
        {
            get => children;
            set
            {
                children = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Children"));
            }
        }
        private bool IsNotLeaf()
        {
            return Children?.Count(c => c != null) > 0;
        }

        public bool IsExpanded
        {
            get
            {
                return IsNotLeaf();
            }
            set
            {
                if (value == false)
                    ClearChildren();
            }
        }

        private void ClearChildren()
        {
            this.Children = new ObservableCollection<RedBlackTreeNodeViewModel<T>>();
            this.Children.Add(null);
        }

        private NodeType type;

        public NodeType Type
        {
            get => type;
            set
            {
                type = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Type"));
            }
        }

        private bool isLeft;

        public bool IsLeft
        {
            get => isLeft;
            set
            {
                isLeft = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsLeft"));
            }
        }
        private void UpdateNodeProperties(RedBlackTreeNodeDuplicate<T> redBlackTreeNode)
        {
            if (redBlackTreeNode.Left != null)
            {
                var left = new RedBlackTreeNodeViewModel<T>(redBlackTreeNode.Left);
                Children.Add(left);
            }
            if (redBlackTreeNode.Left != null)
            {
                var right = new RedBlackTreeNodeViewModel<T>(redBlackTreeNode.Right);
                Children.Add(right);
            }
            IsLeft = (redBlackTreeNode.Parrent.Left == redBlackTreeNode) ? true : false; 
            Color = redBlackTreeNode.Color;
            Value = redBlackTreeNode.Value;
            if (Color == RedBlackTreeAlgorithms.NodeColor.Black)
            {
                if (IsNotLeaf()) Type = NodeType.BlackRegular;
                else Type = NodeType.BlackLeaf;
            }
            else
            {
                if (IsNotLeaf()) Type = NodeType.RedRegular;
                else Type = NodeType.RedLeaf;
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
