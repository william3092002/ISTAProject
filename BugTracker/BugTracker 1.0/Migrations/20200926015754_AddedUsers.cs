using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_User_UserId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 195, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 198, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 198, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 199, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 199, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 199, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 57, 54, 199, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddressLine1", "AddressLine2", "City", "Country", "FirstName", "LastName", "PhoneNumber", "State", "UserRole", "ZipCode" },
                values: new object[] { 1, "1234 Ewing Dr", null, "Bethesda", "US", "William", "Chan", "240-815-2354", "MD", "Developer", "20817" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_UserId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 852, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 856, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 856, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 25, 21, 39, 40, 857, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_User_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
