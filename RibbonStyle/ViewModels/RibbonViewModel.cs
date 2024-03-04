using CommunityToolkit.Mvvm.ComponentModel;
using RibbonStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.ViewModels
{
   public partial class RibbonViewModel:ObservableObject
    {
        public List<TableTemplate> TableTemplates { get; set; } = new()
        {
            new("/Assets/tt1.png","空白工作簿"),
            new("/Assets/tt2.png","欢迎使用Excel"),
            new("/Assets/tt3.png","公式教程"),
            new("/Assets/tt4.png","数据透视表教程"),
            new("/Assets/tt5.png","超出饼图的教程"),
            new("/Assets/tt6.png","季节性照片日历"),
            new("/Assets/tt7.png","个人月度预算"),
            new("/Assets/tt8.png","具有季节性插图的任意年份日历"),
            new("/Assets/tt9.png","任意年份的单月月历"),
        };
    }
}
