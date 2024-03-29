using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [ObservableProperty]
        ObservableCollection<CommonFileViewModel> files=new();

        [ObservableProperty]
        CommonFileViewModel activeDocument;

        [ObservableProperty]
        List<PaneViewModel> panes=new();

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

            Files = new()
            {
                new CSFileViewModel(){Title="test.cs"},
                new XamlFileViewModel(){Title="test.xaml"},
                new (){Title="common.txt"},
            };
        }
    }
}
