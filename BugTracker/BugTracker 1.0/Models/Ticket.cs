using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Please enter a ticket name")]
        [Display(Name = "Ticket Name")]
        [StringLength(30)]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        [Display(Name = "Project")]
        public int ProjectId { get; set; }
        public string Status { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime TicketCreated { get; set; }
        public DateTime TicketUpdated { get; set; }
        public Project Project { get; set; }
    }
}
