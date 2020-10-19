using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddedMoreInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Description", "Name", "Priority", "ProjectId", "Status", "TicketCreated", "Type", "UserId" },
                values: new object[,]
                {
                    { 5, "Allow users to crete an account and log in to the site", "Log In Module", "Medium", 2, "Open", new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1235), "Feature", null },
                    { 6, "Build a shopping cart feature for the user to add items to cart", "Shopping Cart", "Medium", 2, "Open", new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1258), "Feature", null },
                    { 7, "Trace function doesn't show player's previous cavern correctly after transfered to another cavern by bats", "Bug on Trace", "Medium", 3, "Open", new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1278), "Bug", null },
                    { 8, "previous cavern has the same value as current value if player enter wrong input", "Bug on precious cavern", "Medium", 3, "Open", new DateTime(2020, 9, 25, 22, 11, 26, 450, DateTimeKind.Local).AddTicks(1298), "Bug", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8);

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
        }
    }
}
