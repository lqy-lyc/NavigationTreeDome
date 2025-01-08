using Susu.Wpf.CoustomControl.Converters.Base;
using System.Globalization;
using System.Windows;

namespace Susu.Wpf.CoustomControl.Converters
{
    public class NavigationTreeDepthConverter : ConverterBase
    {
        /// <summary>
        /// 将菜单深度转换成需要的边距值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int depth = (int)value;
            Thickness margin = new Thickness(depth * 20, 0, 0, 0);
            return margin;
        }
    }
}
