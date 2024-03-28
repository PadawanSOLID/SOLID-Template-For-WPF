using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.ViewModels
{
public partial    class PaneViewModel:ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string contentId;
        [ObservableProperty]
        bool isSelected;
        [ObservableProperty]
        bool isActive;

    }
}
