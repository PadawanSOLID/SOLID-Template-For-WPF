using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioStyle.Models;

namespace VisualStudioStyle.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        [ObservableProperty]
        string statusText;

        [ObservableProperty]
        Git git=new();

        [RelayCommand]
        async Task Loaded()
        {
            await Git.GetGitInfo();
        }

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
