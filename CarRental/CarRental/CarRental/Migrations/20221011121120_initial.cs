using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ModelYear = table.Column<int>(nullable: false),
                    DailyPrice = table.Column<double>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    TransmissionType = table.Column<string>(nullable: true),
                    PassengerCount = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    RentDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "Name", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 11, 16, 11, 20, 105, DateTimeKind.Local).AddTicks(5360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercedes.png", "Mercedes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(866), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai.png", "Hyundai", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota.png", "Toyota", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmw.png", "BMW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(1739), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nissan.png", "Nissan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2065), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitsubishi.png", "Mitsubishi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2155), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia.png", "Kia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2240), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chevrolet.png", "Chevrolet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, new DateTime(2022, 10, 11, 16, 11, 20, 111, DateTimeKind.Local).AddTicks(2324), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lexus.png", "Lexus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "black", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "white", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "brown", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "grey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "CreatedAt", "DailyPrice", "DeletedAt", "FuelType", "ModelYear", "Name", "PassengerCount", "TransmissionType", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 16, 9, 1, new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3960), 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2012, "LX570", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 24, 5, 4, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1388), 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Sunny", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 13, 7, 4, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(7343), 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2014, "Rio", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, 2, 4, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6765), 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2013, "Sonata", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 2, 4, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6656), 65.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Ix35", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, 2, 4, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6454), 55.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2015, "Elantra", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, 4, 3, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(5758), 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2011, "X5", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 29, 3, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1787), 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2018, "Prado", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 28, 3, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1708), 120.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2015, "Prado", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 26, 3, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1548), 160.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Land Cruiser", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 23, 5, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1305), 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2013, "Navara", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 22, 6, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1223), 85.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2013, "Pajero", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 18, 1, 2, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(897), 400.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2015, "G-class", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 25, 3, 4, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1470), 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2013, "Camry", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 15, 7, 2, new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3684), 65.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Sportage", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 12, 7, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(7089), 75.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Optima", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, 7, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6982), 55.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Cerato", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, 2, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6880), 75.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2017, "Sonata", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, 2, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6554), 140.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2014, "H1", 9, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, 2, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6326), 85.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2013, "Azera", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 2, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6212), 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2014, "Accent", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, 8, 2, new DateTime(2022, 10, 11, 16, 11, 20, 113, DateTimeKind.Local).AddTicks(6086), 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2013, "Aveo", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 1, 4, 2, new DateTime(2022, 10, 11, 16, 11, 20, 112, DateTimeKind.Local).AddTicks(9609), 250.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2012, "M5", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 21, 6, 1, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1140), 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2013, "L200", 5, "Manual", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 20, 1, 1, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1057), 450.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2016, "V-class", 6, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 19, 1, 1, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(980), 350.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2016, "S-class", 4, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 17, 1, 1, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(716), 350.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2012, "G-class", 5, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 14, 7, 2, new DateTime(2022, 10, 11, 16, 11, 20, 114, DateTimeKind.Local).AddTicks(3184), 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 2013, "Sorento", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 27, 3, 4, new DateTime(2022, 10, 11, 16, 11, 20, 115, DateTimeKind.Local).AddTicks(1632), 300.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2018, "Land Cruiser", 7, "Auto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "CarId", "CreatedAt", "DeletedAt", "ImageUrl", "IsMain", "UpdatedAt", "isDeleted" },
                values: new object[,]
                {
                    { 16, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lexus-570-2012.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 24, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nissan-sunny-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 13, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia-rio-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-sonata-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-ix35-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-elantra-2015.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmw-x5.png", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 29, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota-prado-2018.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 28, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota-prado-2015.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 26, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota-land-cruiser-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 23, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nissan-navara-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 22, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitsubishi-pajero.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 18, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercedes-g-class-2015.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 25, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota-camry-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 15, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia-sportage-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 12, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia-optima-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia-cerato-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-sonata-2017.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-h1-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-azera-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hyundai-accent-2014.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chevrolet-aveo-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmw-m5.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 21, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitsubishi-L200-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 20, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercedes-v-class-2016.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 19, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercedes-s-class-2016.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 17, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercedes-g-class-2012.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 14, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kia-sorento-2013.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 27, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "toyota-land-cruiser-2018.jpg", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_UserId",
                table: "Rentals",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
