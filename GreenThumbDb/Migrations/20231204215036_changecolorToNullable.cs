using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbDb.Migrations
{
    public partial class changecolorToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "color",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "id", "botanical_name", "color", "english_name", "family", "image_url" },
                values: new object[,]
                {
                    { 1, "Cactaceae", "Orange, pink, red, yellow, white", "Cactus", "Cactaceae", null },
                    { 2, "Tropaeolum ", "Red, orange, pink, yellow, white", "Nasturtium", "Tropaeolaceae", null },
                    { 3, "Rosa ", "White, red, pink, yellow, orange", "Rose", "Rosaceae", null },
                    { 4, "Osmanthus fragrans", "White", "Tea Olive", "Oleaceae", null },
                    { 5, "Helianthus annuus 'Teddy Bear'", "Golden yellow", "Teddy Bear Sunflower", "Asteraceae", null },
                    { 6, "Viola", "Purple, orange, white, blue, yellow, red", "Viola", "Violaceae", null },
                    { 7, "Lilium longiflorum", "White, pink", "Easter lily", "Liliaceae", null },
                    { 8, "Cynara scolymus ", "Purple", "Artichoke", "Asteraceae", null },
                    { 9, "Fuchsia ", "Red, pink, white, violet, purple", "Fuchsia", "Onagraceae", null },
                    { 10, "", "", "", "", null },
                    { 11, "Dodecatheon meadia or Primula meadia", "White, pink, purple", "Shooting star", "Primulaceae", null },
                    { 12, "Miscanthus sinensis 'Zebrinus", "Silvery white", "Zebra grass", "Poaceae", null },
                    { 13, "Vanilla plantifolia", "Yellow-green", "Vanilla bean orchid,", "Orchidaceae", null },
                    { 14, "Campanula rotundifolia", "Blue", "Harebells", null, null },
                    { 15, "Allium sativum", null, "Garlic", "Amaryllidaceae", null },
                    { 16, "Camellia", "White, pink, red, yellow, or lavender", "Camellia", "Theaceae", null },
                    { 17, "Delphinium", "Pastel, blue, pink, purple, white", "Delphinium, Larkspur", "Ranunculaceae", null },
                    { 18, "Dahlia", "Red, Pink, Orange, Yellow, Purple, White", "Dahlia", "Dahlia", null },
                    { 19, "Dracaena marginata", "White", "Dragon tree", "Asparagaceae", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.AlterColumn<string>(
                name: "color",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
