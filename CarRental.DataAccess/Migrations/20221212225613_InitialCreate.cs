using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ModelYear = table.Column<short>(type: "smallint", nullable: false),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4565), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4565), "Mercedes", "Mercedes Markası" },
                    { 2, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4568), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4569), "BMV", "BMV Markası" },
                    { 3, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4571), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4571), "Lamborghini", "Lamborghini Markası" },
                    { 4, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4573), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4574), "Ferrari", "Ferrari Markası" },
                    { 5, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4576), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4576), "Opel", "Opel Markası" },
                    { 6, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4578), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4579), "Peugeot", "Peugeot Markası" },
                    { 7, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4581), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4581), "Koenigsegg", "Koenigsegg Markası" },
                    { 8, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4583), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4584), "Aston Martin", "Aston Martin Markası" },
                    { 9, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4586), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4586), "Porsche", "Porsche Markası" },
                    { 10, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4588), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4589), "McLaren", "McLaren Markası" },
                    { 11, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4591), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(4591), "Ford", "Ford Markası" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5425), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5425), "Sarı", "Sarı Rengi" },
                    { 2, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5428), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5429), "Kırmızı", "Kırmızı Rengi" },
                    { 3, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5431), true, false, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(5431), "Mavi", "Mavi Rengi" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "CreatedByName", "CreatedDate", "DailyPrice", "Description", "IsActive", "IsDeleted", "ModelYear", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 1, 1, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8028), 950000.00m, "Iyi bir model 1", true, false, (short)2019, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8029), "1. Araba" },
                    { 2, 2, 2, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8034), 850000.00m, "Iyi bir model 2", true, false, (short)2017, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8035), "2. Araba" },
                    { 3, 3, 3, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8038), 1000000.00m, "Iyi bir model 3", true, false, (short)2021, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8038), "3. Araba" },
                    { 4, 4, 1, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8041), 980000.00m, "Iyi bir model 4", true, false, (short)2020, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8042), "4. Araba" },
                    { 5, 5, 2, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8044), 150000.00m, "Iyi bir model 5", true, false, (short)2014, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8045), "5. Araba" },
                    { 6, 6, 3, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8048), 250000.00m, "Iyi bir model 6", true, false, (short)2021, "InitialCreate", new DateTime(2022, 12, 13, 1, 56, 13, 493, DateTimeKind.Local).AddTicks(8048), "6. Araba" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
