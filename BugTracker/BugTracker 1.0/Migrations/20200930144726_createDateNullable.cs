using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class createDateNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjectCreated",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 189, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 47, 26, 194, DateTimeKind.Local).AddTicks(5903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjectCreated",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 879, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 10, 42, 5, 883, DateTimeKind.Local).AddTicks(7258));
        }
    }
}
