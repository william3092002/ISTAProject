using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class TicketController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly ITicketRecordRepository _ticketRecordRepository;
        //private readonly IUserRepository _userRepository;
        public TicketController( ITicketRepository ticketRepository, IProjectRepository projectRepository, ITicketRecordRepository ticketRecordRepository)
        {
            _projectRepository = projectRepository;
            _ticketRepository = ticketRepository;
            _ticketRecordRepository = ticketRecordRepository;
            //_userRepository = userRepository;
        }
        public IActionResult TicketsByProject(int id)
        {
            var tickets = _ticketRepository.GetTicketByProjectId(id);
            if (tickets == null)
                return NotFound();
            return View(tickets);
        }
        public IActionResult List(string searchString)
        {
            TicketListViewModel ticketListViewModel = new TicketListViewModel();
            ticketListViewModel.Tickets = _ticketRepository.AllTickets;

            if (!string.IsNullOrEmpty(searchString))
            {
                ticketListViewModel.Tickets = ticketListViewModel.Tickets.Where(
                    t => t.Name.Contains(searchString) | 
                    t.Project.ProjectName.Contains(searchString) |
                    t.Status.Contains(searchString) |
                    t.Priority.Contains(searchString) |
                    t.Type.Contains(searchString)
                    );
            }

            return View(ticketListViewModel);
        }
        public IActionResult TicketDetail(int id)
        {
            TicketEditViewModel detail = new TicketEditViewModel();
            detail.ticket = _ticketRepository.GetTicketById(id);
            detail.record = _ticketRecordRepository.GetRecordByTicketId(id);
            detail.records = _ticketRecordRepository.GetRecordsByTicketId(id);

                if (detail.ticket.Status == detail.record.Status
                    & detail.ticket.Priority == detail.record.Priority
                    & detail.ticket.Description == detail.record.TicketDescription)
                    _ticketRecordRepository.DeleteLastRecord(detail.record);


            return View(detail);
        }
        public IActionResult Create(int id)
        {
            TicketListViewModel ticketListViewModel = new TicketListViewModel();
            ticketListViewModel.Projects = _projectRepository.AllProjects;
            ticketListViewModel.ticket = _ticketRepository.GetTicketById(id);
            return View(ticketListViewModel);
        }
        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            //TicketListViewModel ticketListViewModel = new TicketListViewModel();
            if (ModelState.IsValid)
            {
                _ticketRepository.CreateTicket(ticket);
                return RedirectToAction("List");
            }
            return View(ticket);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Ticket ticket = _ticketRepository.GetTicketById(id);

            TicketRecord _record = new TicketRecord()
            {
                TicketId = ticket.TicketId,
                TicketDescription = ticket.Description,
                TicketUpdatedTime = ticket.TicketUpdated,
                Status = ticket.Status,
                Priority = ticket.Priority,
                ProjectId = ticket.ProjectId,
                TicketName = ticket.Name
            };
            _ticketRecordRepository.CreateRecord(_record);
            TicketEditViewModel ticektEditViewModel = new TicketEditViewModel()
            {
                
                TicketId = ticket.TicketId,
                record = _record,
                Name = ticket.Name,
                TicketCreated = ticket.TicketCreated,
                TicketUpdated = ticket.TicketUpdated,
                Type = ticket.Type,
                ProjectId = ticket.ProjectId,
                Priority = ticket.Priority,
                Status = ticket.Status,
                Project = ticket.Project,
                Description = ticket.Description, 
            };
            return View(ticektEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(TicketEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _ticketRepository.UpdateTicket(model);
                return RedirectToAction("TicketDetail", model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Ticket ticket = _ticketRepository.GetTicketById(id);
            _ticketRepository.DeleteTicket(ticket);
            return RedirectToAction("List");
        }
    }
}
