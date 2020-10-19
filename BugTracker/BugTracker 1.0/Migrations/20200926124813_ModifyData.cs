using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ModifyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Name", "TicketCreated" },
                values: new object[] { "Bug on previous cavern", new DateTime(2020, 9, 26, 8, 48, 13, 356, DateTimeKind.Local).AddTicks(1364) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 445, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 449, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 449, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "Name", "TicketCreated" },
                values: new object[] { "Bug on precious cavern", new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1298) });
        }
    }
}
