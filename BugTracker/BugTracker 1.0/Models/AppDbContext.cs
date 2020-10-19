using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BugTracker.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TicketRecord> TicketRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 1, ProjectName = "Bug Tracker", Description = "An application that track the bugs of a project", ProjectCreated = DateTime.Now, Status = "In-Progress", ProjectManager = "Carol Lin"});
            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 2, ProjectName = "William's Pie Shop", Description = "An on-line e-store that sells delicious pies", ProjectCreated = DateTime.Now, Status = "In-Progress", ProjectManager = "Jackie Chan" });
            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 3, ProjectName = "Hunt the Wumpus", Description = "Recreation of the first adventure video game Hunt The Wumpus", ProjectCreated = DateTime.Now, Status = "In-Progress", ProjectManager = "Steven Fairchild" });

            modelBuilder.Entity<TicketRecord>().HasData(new TicketRecord { ProjectId = 1, RecordId = 1, TicketId = 18 });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 1,
                Name = "View Ticket",
                Type = "Feature",
                Description = "Allow users to view tickets created under the project",
                Priority = "High",
                Status = "Open",
                ProjectId = 1,
                TicketCreated = DateTime.Now
                
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 2,
                Name = "Create Ticket",
                Type = "Feature",
                Description = "Allow users to add a ticket",
                Priority = "High",
                Status = "Open",
                ProjectId = 1,
                TicketCreated = DateTime.Now

            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 3,
                Name = "View Project",
                Type = "Feature",
                Description = "Allow users to view projects",
                Priority = "High",
                Status = "Open",
                ProjectId = 1,
                TicketCreated = DateTime.Now

            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 4,
                Name = "Create Project",
                Type = "Feature",
                Description = "Allow users to create projects",
                Priority = "High",
                Status = "Open",
                ProjectId = 1,
                TicketCreated = DateTime.Now

            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 5,
                Name = "Log In Module",
                Type = "Feature",
                Description = "Allow users to crete an account and log in to the site",
                Priority = "Medium",
                Status = "Open",
                ProjectId = 2,
                TicketCreated = DateTime.Now
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 6,
                Name = "Shopping Cart",
                Type = "Feature",
                Description = "Build a shopping cart feature for the user to add items to cart",
                Priority = "Medium",
                Status = "Open",
                ProjectId = 2,
                TicketCreated = DateTime.Now
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 7,
                Name = "Bug on Trace",
                Type = "Bug",
                Description = "Trace function doesn't show player's previous cavern correctly after transfered to another cavern by bats",
                Priority = "Medium",
                Status = "Open",
                ProjectId = 3,
                TicketCreated = DateTime.Now
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = 8,
                Name = "Bug on previous cavern",
                Type = "Bug",
                Description = "previous cavern has the same value as current value if player enter wrong input",
                Priority = "Medium",
                Status = "Open",
                ProjectId = 3,
                TicketCreated = DateTime.Now
            });


        }
    }
}
