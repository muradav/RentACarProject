using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class addBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "Id", "Contact", "Email", "ImageUrl", "Location", "WorkTime" },
                values: new object[] { 1, "+994 55 347 08 80", "hwcarrental@bk.ru", "logo.png", "Nizami küçəsi 203B, AF Business House, 2-ci mərtəbə, Baku 1000, Azerbaijan", "Bazar ertəsi-Şənbə 9:00pm - 5:00pm Bazar:Bağlıdır" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 105, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 112, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1787));
        }
    }
}
