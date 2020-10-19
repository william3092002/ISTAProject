using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Project
    {

        public int ProjectId { get; set; }
        
        [Required(ErrorMessage = "Please enter a project name")]
        [Display(Name ="Project Name")]
        [StringLength(30)]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Please enter a project name")]
        [Display(Name = "Project Manager")]
        [StringLength(30)]
        public string ProjectManager { get; set; }
        public string Status { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime? ProjectUpdated { get; set; }
        public DateTime? ProjectCreated { get; set; }

    }
}
