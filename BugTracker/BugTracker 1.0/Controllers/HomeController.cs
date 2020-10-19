using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IProjectRepository _projectRepository;
        public HomeController(ITicketRepository ticketRepository, IProjectRepository projectRepository)
        {
            _ticketRepository = ticketRepository;
            _projectRepository = projectRepository;
        }
        public ViewResult Index()
        {
            return View();
        }
        public static void check()
        {

        }
    }
}
