using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioStyle.Interfaces;
using VisualStudioStyle.Models;

namespace VisualStudioStyle.Services
{
    public class GitService : IGitService
    {
        string workingDirectory;

        bool hasGitRepo;
        string output;
        string error;

        public void SetGitWorkingDirectory(string solutionPath)
        {
            var dir = Directory.GetParent(solutionPath);
            if (dir.GetDirectories().Any(n => n.FullName.Contains(".git")))
            {
                workingDirectory = dir.FullName;
                hasGitRepo = true;
            }
        }

        bool GitBash(string cmd)
        {
            if (hasGitRepo)
            {
                ProcessStartInfo psi = new();
                psi.FileName = @"C:\Program Files\Git\bin\git";
                psi.WorkingDirectory = workingDirectory;
                psi.Arguments = cmd;
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                Process p = new Process() { StartInfo = psi };
                p.Start();
                error = p.StandardError.ReadToEnd();
                output = p.StandardOutput.ReadToEnd();
                if (string.IsNullOrEmpty(error))
                {
                    return true;
                }
                return false;
            
               
            }
            else
            {
                throw new Exception("No Git Repositories Found!");
            }
        }
        public string GitStatus()
        {
            GitBash("status");
            return output;
        }
        public IEnumerable<GitBranch> GetBranches()
        {
            GitBash("branch -l");
            var r = output;
          
            if (!string.IsNullOrEmpty(r)) 
            {
                var branches = r.Split('\n',StringSplitOptions.RemoveEmptyEntries);
                var gitBranches = branches.Select(n => new GitBranch { HasNewChanges = n.StartsWith('*'), Name = n.StartsWith('*') ? n.Substring(1).Trim() : n.Trim() });
                return gitBranches;
            }
            return null;
        }

        public IEnumerable<GitRepository> GetRepositories()
        {
            throw new NotImplementedException();
        }

        public string ManualCommand()
        {
            throw new NotImplementedException();
        }
    }
}
