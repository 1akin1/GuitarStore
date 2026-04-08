using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuitarStore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/1a1a2e/ffffff&text=Fender+-+Stratocaster");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/16213e/ffffff&text=Gibson+-+Les+Paul");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/1b4332/ffffff&text=Fender+-+Telecaster");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/6b2737/ffffff&text=Gibson+-+SG+Standard");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/d62828/ffffff&text=Ibanez+-+RG550");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/4a0e8f/ffffff&text=PRS+-+Custom+24");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/212529/ffffff&text=ESP+-+LTD+EC-1000");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/9c6644/ffffff&text=Gretsch+-+G2622");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/343a40/ffffff&text=Epiphone+-+Casino");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/560bad/ffffff&text=Schecter+-+Hellraiser+C-1");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/5c4033/ffffff&text=Martin+-+D-28");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/533483/ffffff&text=Taylor+-+214ce");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/3d1f00/ffffff&text=Gibson+-+J-45");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/2b2d42/ffffff&text=Yamaha+-+FG800");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/4a7c59/ffffff&text=Seagull+-+S6+Original");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/774936/ffffff&text=Takamine+-+GN93CE");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/2b2d42/ffffff&text=Yamaha+-+CG182S");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/5e3023/ffffff&text=Cordoba+-+C9+Parlour");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/1b4332/ffffff&text=Kremona+-+Soloist+S65C");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://dummyimage.com/400x300/6d4c41/ffffff&text=Alhambra+-+3C");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/1a1a2e/ffffff?text=Fender+Stratocaster");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/16213e/ffffff?text=Gibson+Les+Paul");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/1b4332/ffffff?text=Fender+Telecaster");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/6b2737/ffffff?text=Gibson+SG");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/d62828/ffffff?text=Ibanez+RG550");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/4a0e8f/ffffff?text=PRS+Custom+24");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/212529/ffffff?text=ESP+EC-1000");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/9c6644/ffffff?text=Gretsch+G2622");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/343a40/ffffff?text=Epiphone+Casino");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/560bad/ffffff?text=Schecter+C-1");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/5c4033/ffffff?text=Martin+D-28");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/533483/ffffff?text=Taylor+214ce");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/3d1f00/ffffff?text=Gibson+J-45");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/2b2d42/ffffff?text=Yamaha+FG800");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/4a7c59/ffffff?text=Seagull+S6");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/774936/ffffff?text=Takamine+GN93CE");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/2b2d42/ffffff?text=Yamaha+CG182S");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/5e3023/ffffff?text=Cordoba+C9");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/1b4332/ffffff?text=Kremona+S65C");

            migrationBuilder.UpdateData(
                table: "Guitar",
                keyColumn: "GuitarID",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://placehold.co/400x300/6d4c41/ffffff?text=Alhambra+3C");
        }
    }
}
