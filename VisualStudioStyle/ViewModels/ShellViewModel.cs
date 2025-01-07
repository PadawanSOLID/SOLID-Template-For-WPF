using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioStyle.Models;
using VisualStudioStyle.Services;

namespace VisualStudioStyle.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        private GitService _gitService;

        [ObservableProperty]
        string statusText = "就绪";

        [ObservableProperty]
        Git git = new();

        [ObservableProperty]
        ObservableCollection<CommonFileViewModel> files = new();

        [ObservableProperty]
        CommonFileViewModel activeDocument;

        [ObservableProperty]
        IEnumerable<LayoutVMBase> panes = new LayoutVMBase[]
        {
            new GitChangeViewModel() ,
        };

        [RelayCommand]
        async Task Loaded()
        {
            SetGitInfo();

        }

        private void SetGitInfo()
        {
            var projectPath = Environment.CurrentDirectory + @"\..\..\..\..";
            _gitService.SetGitWorkingDirectory(projectPath);
            Git.LocalBranches = new(_gitService.GetLocalBranches());
            Git.CurrentBranch = Git.LocalBranches.First(n => n.IsCurrentBranch);
            Git.RemoteBranches = new(_gitService.GetRemoteBranches());
            Git.RepositoryActivity = new(_gitService.GetRepositories());
            Git.CurrentRepository = Git.RepositoryActivity[0];
        }

        [RelayCommand]
        void NewProject()
        {

        }

        public ShellViewModel()
        {

        }

        public ShellViewModel(GitService gitService)
        {
            _gitService = gitService;

            Files = new()
            {
                new CSFileViewModel("test.cs"),
                new XamlFileViewModel("test.xaml"),
               new ("common.txt"),
            };
        }
    }
}
