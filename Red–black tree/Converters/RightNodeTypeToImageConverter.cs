using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace RedBlackTreeVisuals
{
    [ValueConversion(typeof(NodeType), typeof(BitmapImage))]
    class RightNodeTypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var image = "Images/black-regular-right.png";
            switch ((NodeType)value)
            {
                case NodeType.RedRegular:
                    image = "Images/red-regular-right.png";
                    break;
                case NodeType.BlackLeaf:
                    image = "Images/black-leaf-right.png";
                    break;
                case NodeType.RedLeaf:
                    image = "Images/red-leaf-right.png";
                    break;

            }
            return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
