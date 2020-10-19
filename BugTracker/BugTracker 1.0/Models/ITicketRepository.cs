using BugTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> AllTickets { get; }
        IEnumerable<Ticket> GetTicketByProjectId(int projectId);
        Ticket GetTicketById(int ticketId);
        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(Ticket ticket);
    }
}
