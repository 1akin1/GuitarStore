using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GuitarStore.Migrations
{
    /// <inheritdoc />
    public partial class MoreGuitars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "ImageUrl" },
                values: new object[] { "Fender", "Stratocaster - Iconic American electric with three single-coil pickups and contoured body.", "https://placehold.co/400x300/1a1a2e/ffffff?text=Fender+Stratocaster" });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "ImageUrl" },
                values: new object[] { "Gibson", "Les Paul Standard - Classic rock guitar with mahogany body and twin humbucker pickups.", "https://placehold.co/400x300/16213e/ffffff?text=Gibson+Les+Paul" });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 3,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Fender", 1, "Telecaster - Twangy classic with two single-coil pickups and solid ash body.", "https://placehold.co/400x300/1b4332/ffffff?text=Fender+Telecaster", 849.99m });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Gibson", 1, "SG Standard - Lightweight double cutaway with twin humbuckers and slim taper neck.", "https://placehold.co/400x300/6b2737/ffffff?text=Gibson+SG", 1099.99m });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Ibanez", 1, "RG550 - High performance electric with Wizard neck and Edge tremolo system.", "https://placehold.co/400x300/d62828/ffffff?text=Ibanez+RG550", 699.99m });

            migrationBuilder.InsertData(
                table: "Guitar",
                columns: new[] { "GuitarID", "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[,]
                {
                    { 6, "PRS", 1, "Custom 24 - Versatile electric with stunning figured maple top and wide-thin neck.", "https://placehold.co/400x300/4a0e8f/ffffff?text=PRS+Custom+24", 2199.99m },
                    { 7, "ESP", 1, "LTD EC-1000 - Professional electric with set-thru neck and EMG pickups.", "https://placehold.co/400x300/212529/ffffff?text=ESP+EC-1000", 799.99m },
                    { 8, "Gretsch", 1, "G2622 Streamliner - Semi-hollow body with dual broad'tron pickups.", "https://placehold.co/400x300/9c6644/ffffff?text=Gretsch+G2622", 449.99m },
                    { 9, "Epiphone", 1, "Casino - Fully hollow thinline with P-90 style dogear pickups.", "https://placehold.co/400x300/343a40/ffffff?text=Epiphone+Casino", 599.99m },
                    { 10, "Schecter", 1, "Hellraiser C-1 - High output electric with active EMG pickups and set neck.", "https://placehold.co/400x300/560bad/ffffff?text=Schecter+C-1", 749.99m },
                    { 11, "Martin", 2, "D-28 - Premium dreadnought acoustic with Sitka spruce top and rosewood back.", "https://placehold.co/400x300/5c4033/ffffff?text=Martin+D-28", 1799.99m },
                    { 12, "Taylor", 2, "214ce - Grand Auditorium acoustic-electric with a warm balanced tone.", "https://placehold.co/400x300/533483/ffffff?text=Taylor+214ce", 999.99m },
                    { 13, "Gibson", 2, "J-45 Standard - Slope-shouldered dreadnought with warm vintage tone.", "https://placehold.co/400x300/3d1f00/ffffff?text=Gibson+J-45", 1599.99m },
                    { 14, "Yamaha", 2, "FG800 - Solid Sitka spruce top dreadnought with scalloped bracing.", "https://placehold.co/400x300/2b2d42/ffffff?text=Yamaha+FG800", 249.99m },
                    { 15, "Seagull", 2, "S6 Original - Canadian-made acoustic with cedar top and cherry back.", "https://placehold.co/400x300/4a7c59/ffffff?text=Seagull+S6", 399.99m },
                    { 16, "Takamine", 2, "GN93CE - NEX body acoustic-electric with solid cedar top and rosewood.", "https://placehold.co/400x300/774936/ffffff?text=Takamine+GN93CE", 549.99m },
                    { 17, "Yamaha", 3, "CG182S - Classical with solid Engelmann spruce top and warm projecting sound.", "https://placehold.co/400x300/2b2d42/ffffff?text=Yamaha+CG182S", 449.99m },
                    { 18, "Cordoba", 3, "C9 Parlour - Solid cedar top classical with mahogany back and sides.", "https://placehold.co/400x300/5e3023/ffffff?text=Cordoba+C9", 599.99m },
                    { 19, "Kremona", 3, "Soloist S65C - Bulgarian handcrafted classical with solid cedar top.", "https://placehold.co/400x300/1b4332/ffffff?text=Kremona+S65C", 349.99m },
                    { 20, "Alhambra", 3, "3C - Spanish classical with solid Canadian cedar top and sapele back.", "https://placehold.co/400x300/6d4c41/ffffff?text=Alhambra+3C", 499.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "ImageUrl" },
                values: new object[] { "Fender Stratocaster", "Iconic American electric guitar with three single-coil pickups and contoured body.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/GuitareClassique5.png/220px-GuitareClassique5.png" });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "ImageUrl" },
                values: new object[] { "Gibson Les Paul", "Classic rock guitar with mahogany body and twin humbucker pickups.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/GuitareClassique5.png/220px-GuitareClassique5.png" });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 3,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Martin D-28", 2, "Premium dreadnought acoustic with Sitka spruce top and rosewood back.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/GuitareClassique5.png/220px-GuitareClassique5.png", 1799.99m });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Taylor 214ce", 2, "Grand Auditorium acoustic-electric with a warm, balanced tone.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/GuitareClassique5.png/220px-GuitareClassique5.png", 999.99m });

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryID", "Description", "ImageUrl", "Price" },
                values: new object[] { "Yamaha CG182S", 3, "Solid Engelmann spruce top classical with warm, projecting sound.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/GuitareClassique5.png/220px-GuitareClassique5.png", 449.99m });
        }
    }
}
