using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetDeveloperRecruitmentTask.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    VariantId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Name" },
                values: new object[] { "Sharif", "Excel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Centre");

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Specification",
                value: "Standard");

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Specification" },
                values: new object[] { "Purple", "Special" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "Black");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_VariantId",
                table: "OrderDetails",
                column: "VariantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Name" },
                values: new object[] { "RFL", "Helio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Premium");

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Specification",
                value: "Premium");

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Specification" },
                values: new object[] { "Blue", "Premium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "Red");
        }
    }
}
