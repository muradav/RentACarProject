using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarProject.Migrations
{
    public partial class addBaseEntityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 680, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 684, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 21, 19, 45, 30, 685, DateTimeKind.Local).AddTicks(908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 507, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 512, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 513, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 20, 13, 36, 13, 517, DateTimeKind.Local).AddTicks(8799));
        }
    }
}
