using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class addedTimeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickets",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectManager",
                table: "Projects",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectUpdated",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 388, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 391, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Description", "ProjectCreated" },
                values: new object[] { "Recreation of the first adventure video game Hunt The Wumpus", new DateTime(2020, 9, 29, 20, 21, 14, 391, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 29, 20, 21, 14, 392, DateTimeKind.Local).AddTicks(4053));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectUpdated",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectManager",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 314, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Description", "ProjectCreated" },
                values: new object[] { "Recreation of the first computer game Hunt The Wumpus", new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 26, 21, 43, 57, 318, DateTimeKind.Local).AddTicks(7736));
        }
    }
}
