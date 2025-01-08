using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WpfCustomControlLibrary1.Models;

namespace NavigationTreeDome.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<NavigationMenu> Menus { get; set; }

        public MainWindowViewModel()
        {
            Menus = new()
            {
                new(1,0,"Home","工作台",0,true)
                {
                    Childrens = new()
                    {
                        new(3, 1, "Home", "工作台", 1, true)
                        {
                            Childrens = new()
                            {
                                new(7,3,"Home","子项1",2,false)
                            }
                        },
                        new(4, 1, "Home", "站内信", 1, false)
                    }
                },
                new(2,0,"Home","日志管理",0,true)
                {
                    Childrens = new()
                    {
                        new(5,2,"Home","异常日志",1,false),
                        new(6, 2, "Home", "业务日志", 1, false)
                    }
                }
            };
        }
    }
}
