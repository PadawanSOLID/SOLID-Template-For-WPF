using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioStyle.Models;

namespace VisualStudioStyle.Interfaces
{
   public interface IGitService
    {
        IEnumerable<GitBranch > GetRemoteBranches();

        IEnumerable<GitBranch > GetLocalBranches();

        IEnumerable<GitRepositoryActivity> GetRepositories();

        bool GitBash(string cmd);
        
    }
}
