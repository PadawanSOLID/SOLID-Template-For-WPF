using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RibbonStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.ViewModels
{
    public partial class RibbonViewModel : ObservableObject
    {
        public RibbonViewModel()
        {

        }


        public List<StartMenuItem> StartMenuItems { get; set; } = new()
        {
            new("Home","开始"),
            new("File","新建"),
            new("Folder","打开"),
        };

        public List<StartMenuItem> Settings { get; set; } = new()
        {
            new("","帐户"),
            new("","反馈"),
            new("","选项"),
        };

        [RelayCommand]
        void Closing()
        {

        }
    }
}
