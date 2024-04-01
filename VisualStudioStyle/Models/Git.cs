using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.Models
{
    public partial class Git : ObservableObject
    {
        string repoUrl;
        bool hasRemote;
        [ObservableProperty]
        int inCount;
        [ObservableProperty]
        int outCount;
        [ObservableProperty]
        int changeCount;
        [ObservableProperty]
        GitBranch currentBranch;
        [ObservableProperty]
        ObservableCollection<GitBranch> localBranches;
        [ObservableProperty]
        ObservableCollection<GitBranch> remoteBranches;
        [ObservableProperty]
        ObservableCollection<string> otherRepos;
        [ObservableProperty]
        ObservableCollection<string> activeRepos;
        public async Task GetGitInfo()
        {
            if (!hasRemote)
            {
               LocalBranches = new()
                {
                 //new(){Author="solid",   "main",
                 //   "devlop",
                 //   "alphy",
                 //   "beta"
                };
                CurrentBranch = LocalBranches.FirstOrDefault();
            }
            await Task.CompletedTask;
        }

    }
}
