using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class addAbotTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    HeaderDesc = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Desc", "HeaderDesc", "ImageUrl", "Title" },
                values: new object[] { 1, "Hot Wheel Car Rental şirkəti yeni yaranmasına baxmayaraq, ölkədə ən böyük avtomobil qarajına sahibdir. Bizim bütün avtomobillərimiz  bütün standartlara cavab verən, ekoloji tələblərə riayət edən yeni avtomobillərdir. Bizim şirkət avtomobil icarəsi bazarına yeni daxil olduğu üçün sərfəli qiymətlərlə digər şirkətləri üstələyir. Kirayə maşın bazarında çox şirkətin olmasına baxmayaraq keyfiyyətli və təhlükəsiz şirkət azlıq təşkil edir.", "Əziz şəhərimizin qonaqları sizi “HOT WHEEL CAR RENTAL” şirkəti olaraq salamlayırıq.", "hero_2.jpg", "BİZ KİMİK" });

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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "Name", "UpdatedAt", "isDeleted" },
                values: new object[] { 10, new DateTime(2022, 10, 13, 10, 48, 26, 828, DateTimeKind.Local).AddTicks(6727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tesla.png", "Tesla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 829, DateTimeKind.Local).AddTicks(9486), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(931), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1180), "Qaz" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1340), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1512), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1671), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1813), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(1973), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2131), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2303), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2448), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2592), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(2751), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3164), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3325), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3497), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3664), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3815), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(3966), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4123), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4273), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4426), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4574), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4741), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(4909), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5069), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5226), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5393), "Dizel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5543), "Benzin" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "qara");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "ağ");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "qəhvəyi");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "boz");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mavi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "qırmızı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ImageUrl", "Name", "Position", "Surname" },
                values: new object[,]
                {
                    { 6, "orxn.jpg", "Orxa", "CEO", "Qəhrəmanov" },
                    { 5, "samir.jpg", "Samir", "Mütəxəssis", "Əmiraslanov" },
                    { 4, "umud.jpg", "Umud", "Mütəxəssis", "Umudov" },
                    { 3, "farid.jpg", "Fərid", "Developer", "Balıyev" },
                    { 2, "rashid.jpg", "Rəşid", "CFO", "Məmməmdov" },
                    { 1, "murad.jpg", "Murad", "CEO", "Vəliyev" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "CreatedAt", "DailyPrice", "DeletedAt", "FuelType", "ModelYear", "Name", "PassengerCount", "TransmissionType", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 30, 10, 2, new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5692), 250.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrik", 2016, "Tesla X", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 32, 10, 4, new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(6000), 250.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrik", 2017, "Tesla 3", 4, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 31, 10, 5, new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(5844), 270.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrik", 2018, "Tesla S", 4, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 33, 5, 6, new DateTime(2022, 10, 13, 10, 48, 26, 830, DateTimeKind.Local).AddTicks(6274), 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrik", 2017, "Leaf", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "CarId", "CreatedAt", "DeletedAt", "ImageUrl", "IsMain", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 30, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tesla-x-2016.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 32, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tesla-3-2017.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 31, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tesla-s-2018.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 33, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nissan-leaf-2017.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

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
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(1476), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2615), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2785), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(2919), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3055), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3203), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3341), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3464), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3563), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3789), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(3934), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4058), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4176), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4303), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4423), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4544), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4663), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4793), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(4913), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5264), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5457), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5569), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5684), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5808), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(5931), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6050), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6175), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6297), "Diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "FuelType" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 58, 44, 791, DateTimeKind.Local).AddTicks(6417), "Petrol" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "black");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "brown");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "grey");
        }
    }
}
