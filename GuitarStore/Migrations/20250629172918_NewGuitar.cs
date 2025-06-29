using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GuitarStore.Migrations
{
    /// <inheritdoc />
    public partial class NewGuitar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Guitar",
                columns: table => new
                {
                    GuitarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitar", x => x.GuitarID);
                    table.ForeignKey(
                        name: "FK_Guitar_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderedItems",
                columns: table => new
                {
                    OrderedItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    GuitarID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderedItems", x => x.OrderedItemID);
                    table.ForeignKey(
                        name: "FK_orderedItems_Guitar_GuitarID",
                        column: x => x.GuitarID,
                        principalTable: "Guitar",
                        principalColumn: "GuitarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderedItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Type" },
                values: new object[,]
                {
                    { 1, "Electric" },
                    { 2, "Acoustic" }
                });

            migrationBuilder.InsertData(
                table: "Guitar",
                columns: new[] { "GuitarID", "Brand", "CategoryID", "ImageUrl", "Price" },
                values: new object[] { 1, "Fender", 1, "https://commons.wikimedia.org/wiki/Category:Fender_Stratocaster#/media/File:Fender_Highway_1_Stratocaster.jpg", 899.99m });

            migrationBuilder.CreateIndex(
                name: "IX_Guitar_CategoryID",
                table: "Guitar",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_orderedItems_GuitarID",
                table: "orderedItems",
                column: "GuitarID");

            migrationBuilder.CreateIndex(
                name: "IX_orderedItems_OrderID",
                table: "orderedItems",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderedItems");

            migrationBuilder.DropTable(
                name: "Guitar");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
