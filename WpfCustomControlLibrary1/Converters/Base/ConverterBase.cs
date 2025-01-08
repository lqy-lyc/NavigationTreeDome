using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Susu.Wpf.CoustomControl.Converters.Base
{
    /// <summary>
    /// 转换器基类
    /// </summary>
    /// <typeparam name="T">当前转换器的类型</typeparam>
    public abstract class ConverterBase : MarkupExtension, IValueConverter
    {
        /// <summary>
        /// 转换后的委托
        /// </summary>
        public Func<object, Type, object, CultureInfo, object>? _overrideConvertBack;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="converter">当前转换器</param>
        public ConverterBase()
        {
            _overrideConvertBack = null;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="converter">当前转换器</param>
        /// <param name="overrideConvertBack">转换后处理的委托</param>
        public ConverterBase(Func<object, Type, object, CultureInfo, object> overrideConvertBack)
        {
            _overrideConvertBack = overrideConvertBack;
        }

        /// <summary>
        /// 转换处理
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// 转换后处理
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return _overrideConvertBack?.Invoke(value, targetType, parameter, culture);
        }


        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
