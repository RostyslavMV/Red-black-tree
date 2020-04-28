using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeVisuals
{
    class RedBlackTreeViewModel<T> : INotifyPropertyChanged
    {
        public RedBlackTreeNodeViewModel<T> root;
        public RedBlackTreeNodeViewModel<T> Root
        {
            get => root;
            set
            {
                root = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Root"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
