using RedBlackTreeAlgorithms;
using System;
using System.Collections.Generic;
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
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
