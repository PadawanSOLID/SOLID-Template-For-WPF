using CommunityToolkit.Mvvm.ComponentModel;
using RibbonStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RibbonStyle.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBackStageOpen=false;
        public List<GridItemStyle> GridItemStyles { get; set; } = new()
        {
            new(){Name="常规"},
            new()
            {
                Name="差",
                Background=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFC7CE")),
                Foreground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB7333B")),
            },
             new()
            {
                Name="好",
                Background=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC6EFCE")),
                Foreground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF126C00")),
            }, new()
            {
                Name="适中",
                Background=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFEB9C")),
                Foreground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9C5700")),
            },
        };
    }
}
