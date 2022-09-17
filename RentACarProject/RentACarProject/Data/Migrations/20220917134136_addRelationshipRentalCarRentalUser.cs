using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarProject.Migrations
{
    public partial class addRelationshipRentalCarRentalUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Rentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 961, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 966, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 967, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 17, 41, 34, 968, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RentalId",
                table: "AspNetUsers",
                column: "RentalId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Rentals_RentalId",
                table: "AspNetUsers",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Rentals_RentalId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RentalId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "AspNetUsers");

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
    }
}
