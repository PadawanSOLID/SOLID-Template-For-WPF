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
