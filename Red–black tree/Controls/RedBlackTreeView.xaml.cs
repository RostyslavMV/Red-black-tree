using RedBlackTreeAlgorithms;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RedBlackTreeVisuals
{
    /// <summary>
    /// Interaction logic for RedBlackTreeView.xaml
    /// </summary>
    public partial class RedBlackTreeView
    {
        public RedBlackTreeView()
        {
            InitializeComponent();
            RedBlackTree<int> RBtree = new RedBlackTree<int>();
            RBtree.Add(5);
            RBtree.Add(4);
            RBtree.Add(3);
            RBtree.Add(7);
            var tree = new RedBlackTreeViewModel<int>(RBtree);
            this.DataContext = tree;

        }
    }

    public class LeftRightItemTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;
           BaseNodeViewModel node = item as BaseNodeViewModel;
            if (node.Position == NodePosition.Left)
                {
                    return element.FindResource("LeftItemTemplate") as DataTemplate;
                }
                else if (node.Position == NodePosition.Right)
                {
                    return element.FindResource("RightItemTemplate") as DataTemplate;
                }
                else return element.FindResource("RootItemTemplate") as DataTemplate;
        }
    }
}
