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
    public partial class GitChangeViewModel : AnchorVMBase
    {
        public const string PaneContentId = "Pane";
        [ObservableProperty]
        Git git;
        [ObservableProperty]
        string commitMessage;
        [ObservableProperty]
        bool doChange;
        [ObservableProperty]
        ObservableCollection<GitStorage> storages;
        [ObservableProperty]
        ObservableCollection<GitChange> changes;

        public GitChangeViewModel():base("Git Changes")
        {
            ContentId= PaneContentId;
        }

        [RelayCommand]
        async Task Fetch()
        {

        }
        [RelayCommand]
        async Task Pull()
        {

        }
        [RelayCommand]
        async Task Push()
        {

        }
        [RelayCommand]
        async Task Commit()
        {

        }
        [RelayCommand]
        async Task Synchronize()
        {

        }
    }
}
