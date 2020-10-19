using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class CreationTimeBindNever : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 398, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 402, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 402, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 29, 1, 403, DateTimeKind.Local).AddTicks(2673));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 698, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 702, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 702, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 12, 42, 703, DateTimeKind.Local).AddTicks(3572));
        }
    }
}
