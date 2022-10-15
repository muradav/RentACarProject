using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class addPropUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 813, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 816, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 6, 35, 817, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name", "Position" },
                values: new object[] { "orxan.jpg", "Orxan", "Mütəxəssis" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 823, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 829, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name", "Position" },
                values: new object[] { "orxn.jpg", "Orxa", "CEO" });
        }
    }
}
