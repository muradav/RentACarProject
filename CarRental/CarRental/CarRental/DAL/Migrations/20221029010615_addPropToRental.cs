using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.DAL.Migrations
{
    public partial class addPropToRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceNo",
                table: "Rentals",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isPaid",
                table: "Rentals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 276, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 289, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "ColorId", "CreatedAt", "DailyPrice", "FuelType", "ModelYear", "Name", "PassengerCount" },
                values: new object[] { 3, 2, new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(226), 120.0, 2, 2015, "Prado", 7 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "ColorId", "CreatedAt", "DailyPrice", "FuelType", "ModelYear", "Name", "PassengerCount" },
                values: new object[] { 4, 3, new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3041), 200.0, 1, 2011, "X5", 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 291, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 290, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 29, 5, 6, 13, 301, DateTimeKind.Local).AddTicks(6924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "isPaid",
                table: "Rentals");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 713, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "ColorId", "CreatedAt", "DailyPrice", "FuelType", "ModelYear", "Name", "PassengerCount" },
                values: new object[] { 4, 3, new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4308), 200.0, 1, 2011, "X5", 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BrandId", "ColorId", "CreatedAt", "DailyPrice", "FuelType", "ModelYear", "Name", "PassengerCount" },
                values: new object[] { 3, 2, new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5869), 120.0, 2, 2015, "Prado", 7 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 718, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 27, 15, 21, 41, 717, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: null);
        }
    }
}
