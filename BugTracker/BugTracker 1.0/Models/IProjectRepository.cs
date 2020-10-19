using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IProjectRepository
    {
        IEnumerable<Project> AllProjects { get; }
        Project GetProjectById(int projectId);
        void CreateProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);

        

        
    }
}
