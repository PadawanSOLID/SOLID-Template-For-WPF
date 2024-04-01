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
        IEnumerable<GitBranch > GetBranches();

        IEnumerable<GitRepository> GetRepositories();

        string ManualCommand();
       

        
    }
}
