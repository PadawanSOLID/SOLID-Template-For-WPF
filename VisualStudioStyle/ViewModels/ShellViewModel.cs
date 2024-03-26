using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        [ObservableProperty]
        string statusText;
        [RelayCommand]
        void NewProject()
        {

        }
        public ShellViewModel()
        {
            StatusText = "就绪";
        }
    }
}
