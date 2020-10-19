using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BugTracker.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectRepository(AppDbContext appDbContext)
        {
            
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> AllProjects => _appDbContext.Projects;
        public Project GetProjectById(int projectId)
        {
            return _appDbContext.Projects.FirstOrDefault(p => p.ProjectId == projectId);
        }
        public void CreateProject(Project project)
        {
            project.ProjectCreated = DateTime.Now;

            _appDbContext.Projects.Add(project);

            _appDbContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            
            project.ProjectUpdated = DateTime.Now;

            _appDbContext.Projects.Update(project);

            _appDbContext.SaveChanges();
        }
        public void DeleteProject(Project project)
        {
            _appDbContext.Projects.Remove(project);
            _appDbContext.SaveChanges();
        }
    }
}
