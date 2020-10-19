using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class DetailViewModel
    {
        public Project projet { get; set; }
        public Ticket ticket { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Ticket> OpenTickets { get; set; }
        public IEnumerable<Ticket> CompleteTickets { get; set; }
        public IEnumerable<TicketRecord> Records { get; set; }
    }
}
