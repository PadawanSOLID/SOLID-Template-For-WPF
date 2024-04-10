using ControlzEx.Standard;
using Newtonsoft.Json;
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
        string output;
        string error;

        public bool HasGitRepo { get; private set; }

        public void SetGitWorkingDirectory(string solutionPath)
        {
            if (Directory.GetDirectories(solutionPath).Any(n => n.Contains(".git")))
            {
                workingDirectory = solutionPath;
                HasGitRepo = true;
            }
        }

        public bool GitBash(string cmd)
        {
            if (HasGitRepo)
            {
                ProcessStartInfo psi = new();
                psi.FileName = @"D:\Git\bin\git";
                psi.WorkingDirectory = workingDirectory;
                psi.Arguments = cmd;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
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
            if (GitBash("status"))
            {
                return output;
            }
            return error;
        }

        public IEnumerable<GitBranch> GetLocalBranches()
        {
            if (GitBash("branch -l"))
            {
                var r = output;
                if (!string.IsNullOrEmpty(r))
                {
                    var branches = r.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                    var gitBranches = branches.Select(n => new GitBranch
                    {
                        IsCurrentBranch = n.StartsWith('*'),
                        Name = n.StartsWith('*') ? n.Substring(1).Trim() : n.Trim(),
                        IsLocal = true
                    });
                    return gitBranches;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Git exception");
            }
        }

        public IEnumerable<GitBranch> GetRemoteBranches()
        {
            if (GitBash("branch -r"))
            {
                var r = output;
                if (!string.IsNullOrEmpty(r))
                {
                    var branches = r.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                    var gitBranches = branches.Select(n => new GitBranch
                    {
                        Name = n.Trim()
                    }).ToArray()[1..];
                    return gitBranches;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Git exception");
            }
        }

        public IEnumerable<GitRepositoryActivity> GetRepositories()
        {
            var repos = JsonConvert.DeserializeObject<IList<GitRepository>>(File.ReadAllText("gitrepo.json"));
            if (repos != null && repos.Count > 0)
            {
                List<GitRepositoryActivity> repositoryActivities = new()
                {
                    new(){Activity="活动存储库",Repositories=new()},
                    new(){Activity="其他"}
                };
                var activeRepo = repos.FirstOrDefault();
                repositoryActivities[0].Repositories.Add(activeRepo);
                if (repos.Skip(0).Any())
                {
                    repositoryActivities[1].Repositories = new(repos.Skip(1));
                }
                return repositoryActivities;
            }
            else
            {
                return null;
            }

        }
    }
}
