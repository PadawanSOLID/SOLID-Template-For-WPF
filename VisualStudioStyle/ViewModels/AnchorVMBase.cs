using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.ViewModels
{
    public partial class AnchorVMBase : LayoutVMBase
    {
        [ObservableProperty]
        bool isSelected;
        [ObservableProperty]
        bool isActive;
        public AnchorVMBase(string name) : base(name)
        {
        }
    }
}
