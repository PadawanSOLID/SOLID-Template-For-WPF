using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioStyle.Models
{
   public  class GitRepositoryActivity
    {
        public string Activity { get; set; }

        public ObservableCollection<GitRepository> Repositories { get; set; }
    }
}
