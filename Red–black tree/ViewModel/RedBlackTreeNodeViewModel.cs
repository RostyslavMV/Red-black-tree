using RedBlackTreeAlgorithms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeVisuals
{
    class BaseNodeViewModel : INotifyPropertyChanged
    {

        protected NodePosition position;

        public NodePosition Position
        {
            get => position;
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    class RedBlackTreeNodeViewModel<T> : BaseNodeViewModel
    {
        public RedBlackTreeNodeViewModel(RedBlackTreeNode<T> redBlackTreeNode)
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
                OnPropertyChanged();
            }
        }

        private RedBlackTreeAlgorithms.NodeColor color;
        public RedBlackTreeAlgorithms.NodeColor Color
        {
            get => color;
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<RedBlackTreeNodeViewModel<T>> children = new ObservableCollection<RedBlackTreeNodeViewModel<T>>();
        public ObservableCollection<RedBlackTreeNodeViewModel<T>> Children
        {
            get => children;
            set
            {
                children = value;
                OnPropertyChanged();
            }
        }
        private bool IsNotLeaf()
        {
            return Children?.Count(c => c != null) > 0;
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
                OnPropertyChanged();
            }
        }

        private void UpdateNodeProperties(RedBlackTreeNode<T> redBlackTreeNode)
        {
            if (redBlackTreeNode != null)
            {
                if (redBlackTreeNode.Left != null)
                {
                    var left = new RedBlackTreeNodeViewModel<T>((RedBlackTreeNode<T>)redBlackTreeNode.Left);
                    Children.Add(left);
                }
                if (redBlackTreeNode.Right != null)
                {
                    var right = new RedBlackTreeNodeViewModel<T>((RedBlackTreeNode<T>)redBlackTreeNode.Right);
                    Children.Add(right);
                }
                Color = redBlackTreeNode.Color;
                Value = redBlackTreeNode.Data;
                if (redBlackTreeNode.Parent == null) Position = NodePosition.Root;
                else Position = (redBlackTreeNode.Parent.Left == redBlackTreeNode) ? NodePosition.Left : NodePosition.Right;
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
        }
    }
}
