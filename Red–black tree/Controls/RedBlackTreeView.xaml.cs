using RedBlackTreeAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            var tree = new RedBlackTreeViewModel<int>(RedBlackTreeDuplicate<int>.MakeExampleTree());
            this.DataContext = tree;
            
        }
    }

    public class LeftRightItemTemplateSelector<T> : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;
            RedBlackTreeNodeViewModel<T> node = item as RedBlackTreeNodeViewModel<T>;
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
