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
   public partial class Git:ObservableObject
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
        string currentBranch;
        [ObservableProperty]
         ObservableCollection<string> branches;

        public async Task GetGitInfo()
        {
            if (!hasRemote)
            {
                Branches = new()
                {
                    "main",
                    "devlop",
                    "alphy",
                    "beta"
                };
                CurrentBranch = Branches[0];
            }
            await Task.CompletedTask;
        }

    }
}
