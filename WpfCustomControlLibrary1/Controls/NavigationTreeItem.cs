using System.Windows;
using System.Windows.Controls;
using WpfCustomControlLibrary1.Models;

namespace WpfCustomControlLibrary1.Controls
{
    public class NavigationTreeItem : TreeViewItem
    {
        static NavigationTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationTreeItem), new FrameworkPropertyMetadata(typeof(NavigationTreeItem)));
        }

        public NavigationTreeItem()
        {
            MouseLeftButtonUp += NavigationTreeItem_MouseLeftButtonUp;
            MouseDoubleClick += NavigationTreeItem_MouseDoubleClick;
        }

        /// <summary>
        /// 定义子项
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new NavigationTreeItem();
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationTreeItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 鼠标左键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationTreeItem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationTreeItem treeViewItem = sender as NavigationTreeItem;
            if (treeViewItem == null || e.Handled) return;
            treeViewItem.IsExpanded = !treeViewItem.IsExpanded;
            if (DataContext is NavigationMenu menu)
            {
                treeViewItem.IsSelected = !menu.IsChildren;
            }
            e.Handled = true;
        }
    }
}
