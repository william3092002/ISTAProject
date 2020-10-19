using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class addSeedRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 383, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.InsertData(
                table: "TicketRecords",
                columns: new[] { "RecordId", "Priority", "ProjectId", "Status", "TicketDescription", "TicketId", "TicketName", "TicketUpdatedTime", "UpdatedByUserId" },
                values: new object[] { 1, null, 1, null, null, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 15, 30, 40, 387, DateTimeKind.Local).AddTicks(6655));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TicketRecords",
                keyColumn: "RecordId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 144, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 10, 3, 13, 39, 51, 148, DateTimeKind.Local).AddTicks(3622));
        }
    }
}
