using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class TicketEditViewModel : Ticket
    {
        public Ticket ticket { get; set; }
        public TicketRecord record { get; set; }
        public IEnumerable<TicketRecord> records { get; set; }
    }
}
