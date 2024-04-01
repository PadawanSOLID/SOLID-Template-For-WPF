using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.ViewModels
{
    public partial class CommonFileViewModel : PaneViewModel
    {
        [ObservableProperty]
        string filePath;
        [ObservableProperty]
        string textContent;
        [ObservableProperty]
        bool isDirty;
        [ObservableProperty]
        List<double> scalePercents = new()
        {
            0.2,0.5,0.7,1,1.5,2,4
        };
        [ObservableProperty]
        double scalePercent=1;
        [RelayCommand]
        void Save()
        {

        }
        [RelayCommand]
        void SaveAs()
        {

        }
        [RelayCommand]
        void Close()
        {

        }

    }
}
