using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfCustomControlLibrary1.Models
{
    public partial class NavigationMenu : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public int pid;

        [ObservableProperty]
        private string icon;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private int depth;

        [ObservableProperty]
        private bool isChildren;

        public ObservableCollection<NavigationMenu> Childrens { get; set; } = new();

        public NavigationMenu(int id, int pid, string icon, string name, int depth, bool isChildren)
        {
            this.id = id;
            this.pid = pid;
            this.icon = icon;
            this.name = name;
            this.depth = depth;
            this.isChildren = isChildren;
        }
    }
}
