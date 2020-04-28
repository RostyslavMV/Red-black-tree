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
        RedBlackTreeNodeViewModel(RedBlackTreeNodeDuplicate<T> redBlackTreeNode)
        {
            Value = redBlackTreeNode.Value;
            Color = redBlackTreeNode.Color;
            if (redBlackTreeNode.Left != null)
                Children.Add(redBlackTreeNode.Left);
            if (redBlackTreeNode.Right != null)
                Children.Add(redBlackTreeNode.Right);
            UpdateNodeType();
        }
        public T value;
        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
            }
        }

        public RedBlackTreeAlgorithms.NodeColor color;
        public RedBlackTreeAlgorithms.NodeColor Color
        {
            get => color;
            set
            {
                color = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }
        public ObservableCollection<RedBlackTreeNodeDuplicate<T>> children;
        public ObservableCollection<RedBlackTreeNodeDuplicate<T>> Children
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
            this.Children = new ObservableCollection<RedBlackTreeNodeDuplicate<T>>();
            this.Children.Add(null);
        }

        public NodeType type;

        public NodeType Type
        {
            get => type;
            set
            {
                type = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Type"));
            }
        }
        private void UpdateNodeType()
        {
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
