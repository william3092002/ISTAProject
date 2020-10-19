using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly AppDbContext _context;
        public ProjectController(IProjectRepository projectRepository, ITicketRepository ticketRepository, AppDbContext context)
        {
            _projectRepository = projectRepository;
            _ticketRepository = ticketRepository;
            _context = context;
        }
        public ViewResult Projects()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            projectViewModel.Projects = _projectRepository.AllProjects;

            return View(projectViewModel);
        }
        public ViewResult ProjectDetailComplete(int id)
        {
            DetailViewModel detailViewModel = new DetailViewModel();
            detailViewModel.OpenTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Open" || t.Status == "In Work");
            detailViewModel.CompleteTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Complete");
            detailViewModel.projet = _projectRepository.GetProjectById(id);
            detailViewModel.Tickets = _ticketRepository.GetTicketByProjectId(id);
            return View(detailViewModel);
        }
        public ViewResult ProjectDetailAll(int id)
        {
            DetailViewModel detailViewModel = new DetailViewModel();
            detailViewModel.OpenTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Open" || t.Status == "In Work");
            detailViewModel.CompleteTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Complete");
            detailViewModel.projet = _projectRepository.GetProjectById(id);
            detailViewModel.Tickets = _ticketRepository.GetTicketByProjectId(id);
            return View(detailViewModel);
        }

        public ViewResult ProjectDetail(int id)
        {
            DetailViewModel detailViewModel = new DetailViewModel();
            detailViewModel.OpenTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Open" || t.Status == "In Work");
            detailViewModel.CompleteTickets = _ticketRepository.GetTicketByProjectId(id).
                Where(t => t.Status == "Complete");
            detailViewModel.projet = _projectRepository.GetProjectById(id);
            detailViewModel.Tickets = _ticketRepository.GetTicketByProjectId(id);
            return View(detailViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectRepository.CreateProject(project);
                return RedirectToAction("Projects");
            }
            return View(project);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Project project = _projectRepository.GetProjectById(id);
            ProjectEditViewModel projectEditViewModel = new ProjectEditViewModel()
            {
                ProjectId = project.ProjectId,
                ProjectCreated = project.ProjectCreated,
                ProjectUpdated = project.ProjectUpdated,
                ProjectName = project.ProjectName,
                Status = project.Status,
                ProjectManager = project.ProjectManager,
                Description = project.Description
            };
            return View(projectEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(ProjectEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _projectRepository.UpdateProject(model);
                
                return RedirectToAction("Projects");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Project project = _projectRepository.GetProjectById(id);
            _projectRepository.DeleteProject(project);
            return RedirectToAction("Projects");
        }

    }
}
