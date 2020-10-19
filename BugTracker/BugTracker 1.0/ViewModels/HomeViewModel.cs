using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public string CurrentProject { get; set; }

    }
}
