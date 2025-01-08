using System.Windows;
using System.Windows.Controls;

namespace WpfCustomControlLibrary1.Controls
{
    public class NavigationTree : TreeView
    {
        static NavigationTree()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationTree), new FrameworkPropertyMetadata(typeof(NavigationTree)));
        }

        /// <summary>
        /// 定义子项
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new NavigationTreeItem();
        }
    }
}
