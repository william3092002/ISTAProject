using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class TicketListViewModel
    {
        public Ticket ticket { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Project> Projects { get; set; }
            

            


        
    }
}
