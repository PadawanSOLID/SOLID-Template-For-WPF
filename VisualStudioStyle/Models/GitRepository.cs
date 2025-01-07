using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.Models
{
    public partial class GitRepository : ObservableObject
    {
        [ObservableProperty]
        string name;
        [ObservableProperty]
        string path;
        [ObservableProperty]
        string url;
    }
}
