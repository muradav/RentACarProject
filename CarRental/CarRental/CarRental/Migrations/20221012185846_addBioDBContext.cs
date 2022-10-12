using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class addBioDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bio",
                table: "Bio");

            migrationBuilder.RenameTable(
                name: "Bio",
                newName: "Bios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bios",
                table: "Bios",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 785, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 790, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6417));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bios",
                table: "Bios");

            migrationBuilder.RenameTable(
                name: "Bios",
                newName: "Bio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bio",
                table: "Bio",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 884, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 888, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 889, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 12, 22, 35, 47, 890, DateTimeKind.Local).AddTicks(631));
        }
    }
}
