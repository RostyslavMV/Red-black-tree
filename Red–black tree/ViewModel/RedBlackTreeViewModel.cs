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
    class RedBlackTreeViewModel<T> : INotifyPropertyChanged
    {
        public RedBlackTreeViewModel(RedBlackTreeDuplicate<T> redBlackTree)
        {
            Root = new RedBlackTreeNodeViewModel<T>(redBlackTree.Root);
            RootItem = new ObservableCollection<RedBlackTreeNodeViewModel<T>> { Root };
        }

        private RedBlackTreeNodeViewModel<T> root;
        public RedBlackTreeNodeViewModel<T> Root
        {
            get => root;
            set
            {
                root = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<RedBlackTreeNodeViewModel<T>> rootItem;

        public ObservableCollection<RedBlackTreeNodeViewModel<T>> RootItem
        {
            get => rootItem;
            set
            {
                rootItem = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
