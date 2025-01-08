using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfCustomControlLibrary1.Controls
{
    /// <summary>
    /// 上下箭头
    /// </summary>
    public class ChevronSwitch : ToggleButton
    {
        static ChevronSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChevronSwitch), new FrameworkPropertyMetadata(typeof(ChevronSwitch)));
        }
    }
}
