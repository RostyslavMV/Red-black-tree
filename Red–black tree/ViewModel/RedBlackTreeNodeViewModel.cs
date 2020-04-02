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
        public RedBlackTreeAlgorithms.NodeColor Color { get; private set; }
        public ObservableCollection<RedBlackTreeNodeDuplicate<T>> Children { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
