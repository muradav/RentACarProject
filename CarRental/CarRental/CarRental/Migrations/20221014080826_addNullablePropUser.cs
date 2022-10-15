using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class addNullablePropUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 234, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 237, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 12, 8, 25, 238, DateTimeKind.Local).AddTicks(5254));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
