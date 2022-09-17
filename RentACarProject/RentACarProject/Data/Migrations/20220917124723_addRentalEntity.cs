using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarProject.Migrations
{
    public partial class addRentalEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "CarImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    RentDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 610, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 616, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "IsMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 617, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 16, 47, 21, 618, DateTimeKind.Local).AddTicks(2579));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "CarImages");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 221, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 228, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9373));
        }
    }
}
