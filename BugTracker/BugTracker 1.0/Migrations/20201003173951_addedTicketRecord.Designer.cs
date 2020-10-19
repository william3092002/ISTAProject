﻿// <auto-generated />
using System;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201003173951_addedTicketRecord")]
    partial class addedTicketRecord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BugTracker.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ProjectCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("ProjectUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Description = "An application that track the bugs of a project",
                            ProjectCreated = new DateTime(2020, 10, 3, 13, 39, 51, 144, DateTimeKind.Local).AddTicks(563),
                            ProjectManager = "Carol Lin",
                            ProjectName = "Bug Tracker",
                            Status = "In-Progress"
                        },
                        new
                        {
                            ProjectId = 2,
                            Description = "An on-line e-store that sells delicious pies",
                            ProjectCreated = new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9073),
                            ProjectManager = "Jackie Chan",
                            ProjectName = "William's Pie Shop",
                            Status = "In-Progress"
                        },
                        new
                        {
                            ProjectId = 3,
                            Description = "Recreation of the first adventure video game Hunt The Wumpus",
                            ProjectCreated = new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9220),
                            ProjectManager = "Steven Fairchild",
                            ProjectName = "Hunt the Wumpus",
                            Status = "In-Progress"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TicketCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TicketUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            Description = "Allow users to view tickets created under the project",
                            Name = "View Ticket",
                            Priority = "High",
                            ProjectId = 1,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(2765),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 2,
                            Description = "Allow users to add a ticket",
                            Name = "Create Ticket",
                            Priority = "High",
                            ProjectId = 1,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3465),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 3,
                            Description = "Allow users to view projects",
                            Name = "View Project",
                            Priority = "High",
                            ProjectId = 1,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3515),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 4,
                            Description = "Allow users to create projects",
                            Name = "Create Project",
                            Priority = "High",
                            ProjectId = 1,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3538),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 5,
                            Description = "Allow users to crete an account and log in to the site",
                            Name = "Log In Module",
                            Priority = "Medium",
                            ProjectId = 2,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3559),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 6,
                            Description = "Build a shopping cart feature for the user to add items to cart",
                            Name = "Shopping Cart",
                            Priority = "Medium",
                            ProjectId = 2,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3583),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Feature"
                        },
                        new
                        {
                            TicketId = 7,
                            Description = "Trace function doesn't show player's previous cavern correctly after transfered to another cavern by bats",
                            Name = "Bug on Trace",
                            Priority = "Medium",
                            ProjectId = 3,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3602),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Bug"
                        },
                        new
                        {
                            TicketId = 8,
                            Description = "previous cavern has the same value as current value if player enter wrong input",
                            Name = "Bug on previous cavern",
                            Priority = "Medium",
                            ProjectId = 3,
                            Status = "Open",
                            TicketCreated = new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3622),
                            TicketUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Bug"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.TicketRecord", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("TicketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TicketUpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("TicketRecords");
                });

            modelBuilder.Entity("BugTracker.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AddressLine1 = "1234 Ewing Dr",
                            City = "Bethesda",
                            Country = "US",
                            FirstName = "William",
                            LastName = "Chan",
                            PhoneNumber = "240-815-2354",
                            State = "MD",
                            UserRole = "Developer",
                            ZipCode = "20817"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.Ticket", b =>
                {
                    b.HasOne("BugTracker.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BugTracker.Models.TicketRecord", b =>
                {
                    b.HasOne("BugTracker.Models.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId");
                });

            modelBuilder.Entity("BugTracker.Models.User", b =>
                {
                    b.HasOne("BugTracker.Models.Project", null)
                        .WithMany("Users")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
