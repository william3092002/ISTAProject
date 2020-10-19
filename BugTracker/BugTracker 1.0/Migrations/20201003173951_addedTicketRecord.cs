using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class addedTicketRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjectUpdated",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "TicketRecords",
                columns: table => new
                {
                    RecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    TicketName = table.Column<string>(nullable: true),
                    TicketDescription = table.Column<string>(nullable: true),
                    TicketUpdatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketRecords", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_TicketRecords_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 10, 3, 13, 39, 51, 144, DateTimeKind.Local).AddTicks(563), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9073), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 10, 3, 13, 39, 51, 147, DateTimeKind.Local).AddTicks(9220), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_TicketRecords_UpdatedByUserId",
                table: "TicketRecords",
                column: "UpdatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketRecords");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjectUpdated",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 9, 30, 20, 12, 43, 380, DateTimeKind.Local).AddTicks(7782), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 9, 30, 20, 12, 43, 384, DateTimeKind.Local).AddTicks(5671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "ProjectCreated", "ProjectUpdated" },
                values: new object[] { new DateTime(2020, 9, 30, 20, 12, 43, 384, DateTimeKind.Local).AddTicks(5827), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 384, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "TicketCreated",
                value: new DateTime(2020, 9, 30, 20, 12, 43, 385, DateTimeKind.Local).AddTicks(180));
        }
    }
}
