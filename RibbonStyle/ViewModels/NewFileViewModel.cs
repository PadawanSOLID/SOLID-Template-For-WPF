using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.ViewModels
{
    public class NewFileViewModel : ObservableObject
    {
        public List<string> TemplateAdvices { get; set; } = new()
        {
            "业务",
            "个人",
            "规划器和跟踪器",
            "列表",
            "预算",
            "图表",
            "日历",
        };
    }
}
