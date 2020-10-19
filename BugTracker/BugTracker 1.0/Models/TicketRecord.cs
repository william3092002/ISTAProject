using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TicketRecord
    {
        [Key]
        public int RecordId { get; set; }
        public int TicketId { get; set; }
        public int ProjectId { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string TicketName { get; set; }
        public string TicketDescription { get; set; }
        public DateTime TicketUpdatedTime { get; set; }
    }
}
