using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarProject.Migrations
{
    public partial class dropRentalIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Rentals_RentalId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RentalId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rentals",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 455, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 460, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 18, 1, 51, 33, 461, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_UserId1",
                table: "Rentals",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_AspNetUsers_UserId1",
                table: "Rentals",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_AspNetUsers_UserId1",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_UserId1",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rentals");

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "AspNetUsers",
                type: "int",
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
        }
    }
}
