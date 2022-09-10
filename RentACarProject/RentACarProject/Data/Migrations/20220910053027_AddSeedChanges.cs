using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarProject.Migrations
{
    public partial class AddSeedChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6082), "M5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6790), "X5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(6955), "Aveo", "Manual" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7046), "Accent", "Manual" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7132), "Azera" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7234), "Elantra" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FuelType", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7321), "Diesel", "H1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7399), "Ix35" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FuelType", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7485), "Diesel", "Sonata" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7585), "Sonata" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7673), "Cerato" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7762), "Optima" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(7958), "Rio", "Manual" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8062), "Sorento" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8143), "Sportage" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8229), "LX570" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8312), "G-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8413), "G-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8499), "S-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8585), "V-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8665), "L200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8756), "Pajero" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8841), "Navara" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(8933), "Sunny" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9019), "Camry" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9116), "Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9200), "Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9289), "Prado" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 9, 30, 25, 229, DateTimeKind.Local).AddTicks(9373), "Prado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 553, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 556, DateTimeKind.Local).AddTicks(9673), "BMW M5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(136), "BMW X5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(215), "Chevrolet Aveo", "Auto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(264), "Hyundai Accent", "Auto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(309), "Hyundai Azera" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(359), "Hyundai Elantra" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FuelType", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(404), "Petrol", "Hyundai H1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(447), "Hyundai Ix35" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FuelType", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(491), "Petrol", "Hyundai Sonata" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(538), "Hyundai Sonata" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(583), "Kia Cerato" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(626), "Kia Optima" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Name", "TransmissionType" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(670), "Kia Rio", "Auto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(804), "Kia Sorento" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(853), "Kia Sportage" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(897), "Lexus 570" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(942), "Mercedes G-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(988), "Mercedes G-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1032), "Mercedes S-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1077), "Mercedes V-class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1120), "Mitsubishi L200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1162), "Mitsubishi Pajero" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1204), "Nissan Navara" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1247), "Nissan Sunny" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1290), "Toyota Camry" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1385), "Toyota Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1448), "Toyota Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1492), "Toyota Prado" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 2, 4, 37, 557, DateTimeKind.Local).AddTicks(1536), "Toyota Prado" });
        }
    }
}
