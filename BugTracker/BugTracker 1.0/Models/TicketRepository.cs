using BugTracker.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _appDbContext;
        public TicketRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Ticket GetTicketById(int id) =>
            _appDbContext.Tickets.FirstOrDefault(t => t.TicketId == id);
        public IEnumerable<Ticket> AllTickets
        {
            get
            {
                return _appDbContext.Tickets.Include(p => p.Project);
            }
        }
        public IEnumerable<Ticket> GetTicketByProjectId(int projectId) =>
            _appDbContext.Tickets.Where(t => t.ProjectId == projectId);
        public void CreateTicket(Ticket ticket)
        {
            ticket.TicketCreated = DateTime.Now;
            _appDbContext.Tickets.Add(ticket);
            _appDbContext.SaveChanges();
        }
        public void UpdateTicket(Ticket ticket)
        {
            ticket.TicketUpdated = DateTime.Now;
            _appDbContext.Update(ticket);
            _appDbContext.SaveChanges();
        }
        public void DeleteTicket(Ticket tieckt)
        {
            _appDbContext.Remove(tieckt);
            _appDbContext.SaveChanges();
        }
    }
}
