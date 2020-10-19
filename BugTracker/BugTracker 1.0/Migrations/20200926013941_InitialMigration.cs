using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProjectCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRole = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TicketCreated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "ProjectCreated", "ProjectName" },
                values: new object[] { 1, "An application that track the bugs of a project", new DateTime(2020, 9, 25, 21, 39, 40, 852, DateTimeKind.Local).AddTicks(8910), "Bug Tracker" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "ProjectCreated", "ProjectName" },
                values: new object[] { 2, "An on-line e-store that sells delicious pies", new DateTime(2020, 9, 25, 21, 39, 40, 856, DateTimeKind.Local).AddTicks(6250), "William's Pie Shop" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "ProjectCreated", "ProjectName" },
                values: new object[] { 3, "Recreation of the first computer game Hunt The Wumpus", new DateTime(2020, 9, 25, 21, 39, 40, 856, DateTimeKind.Local).AddTicks(6400), "Hunt the Wumpus" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Description", "Name", "Priority", "ProjectId", "Status", "TicketCreated", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Allow users to view tickets created under the project", "View Ticket", "High", 1, "Open", new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(7), "Feature", null },
                    { 2, "Allow users to add a ticket", "Create Ticket", "High", 1, "Open", new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(719), "Feature", null },
                    { 3, "Allow users to view projects", "View Project", "High", 1, "Open", new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(768), "Feature", null },
                    { 4, "Allow users to create projects", "Create Project", "High", 1, "Open", new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(790), "Feature", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProjectId",
                table: "Tickets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
