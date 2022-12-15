using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.DataAccess.Migrations
{
    public partial class user_customer_rental_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                        name: "FK_Rentals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1611), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1616), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1619), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1621), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1629), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1631), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5273), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5277), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5284), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2663), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2665), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "Password" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6173), "batu@inal.com", "Batuhan", true, false, "İnal", "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6174), "User data seed", "12345" },
                    { 2, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6176), "samet@inal.com", "Samet", true, false, "İnal", "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6177), "User data seed", "12345" },
                    { 3, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180), "Ilknur@inal.com", "Ilknur", true, false, "İnal", "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180), "User data seed", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "UserId" },
                values: new object[] { 1, "AE Yazılım", "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6994), true, false, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6995), "1. Musteri", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "UserId" },
                values: new object[] { 2, "Selçuk Üniversitesi", "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6997), true, false, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6998), "2. Musteri", 3 });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CreatedByName", "CreatedDate", "CustomerId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "RentDate", "ReturnDate" },
                values: new object[] { 1, 5, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8974), 1, true, false, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8975), "Ilk kira", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CreatedByName", "CreatedDate", "CustomerId", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "RentDate", "ReturnDate" },
                values: new object[] { 2, 6, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979), 2, true, false, "InitialCreate", new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979), "2. kira", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4568), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4576), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4578), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4581), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4583), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4586), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4588), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4591), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8034), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8038), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8041), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8044), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8048), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5428), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5431) });
        }
    }
}
