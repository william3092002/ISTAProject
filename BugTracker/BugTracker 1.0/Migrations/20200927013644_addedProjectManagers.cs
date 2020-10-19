using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class addedProjectManagers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectManager",
                table: "Projects",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectCreated", "ProjectManager" },
                values: new object[] { new DateTime(2020, 9, 26, 21, 36, 44, 102, DateTimeKind.Local).AddTicks(770), "Carol Lin" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectCreated", "ProjectManager" },
                values: new object[] { new DateTime(2020, 9, 26, 21, 36, 44, 105, DateTimeKind.Local).AddTicks(9176), "Jackie Chan" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectCreated", "ProjectManager" },
                values: new object[] { new DateTime(2020, 9, 26, 21, 36, 44, 105, DateTimeKind.Local).AddTicks(9319), "Steven Fairchild" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 36, 44, 106, DateTimeKind.Local).AddTicks(3640));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectManager",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 749, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 752, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 752, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 17, 48, 51, 753, DateTimeKind.Local).AddTicks(2868));
        }
    }
}
