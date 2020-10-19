using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class addedProjectStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Projects",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectCreated", "Status" },
                values: new object[] { new DateTime(2020, 9, 26, 17, 48, 51, 749, DateTimeKind.Local).AddTicks(2767), "In-Progress" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectCreated", "Status" },
                values: new object[] { new DateTime(2020, 9, 26, 17, 48, 51, 752, DateTimeKind.Local).AddTicks(8626), "In-Progress" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectCreated", "Status" },
                values: new object[] { new DateTime(2020, 9, 26, 17, 48, 51, 752, DateTimeKind.Local).AddTicks(8763), "In-Progress" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 351, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 355, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 355, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1364));
        }
    }
}
