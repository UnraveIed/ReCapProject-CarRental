using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.DataAccess.Migrations
{
    public partial class CarImageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4863), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4867), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4874), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4877), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4879), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4892), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4895), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4897), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4900), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8574), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8578), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8581), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5917), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(263), new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(2491), new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarId", "CreatedDate", "ModifiedDate", "RentDate", "ReturnDate" },
                values: new object[] { 6, new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 12, 21, 16, 28, 2, 803, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9512), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9516), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9519), new DateTime(2022, 12, 21, 16, 28, 2, 802, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImages");

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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8974), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarId", "CreatedDate", "ModifiedDate", "RentDate", "ReturnDate" },
                values: new object[] { 7, new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6173), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180) });
        }
    }
}
