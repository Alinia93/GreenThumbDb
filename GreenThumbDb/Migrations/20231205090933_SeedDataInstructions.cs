using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbDb.Migrations
{
    public partial class SeedDataInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Instructions",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "id", "description", "name", "plant_id" },
                values: new object[,]
                {
                    { 1, "Cacti require four to six hours of bright sunlight daily. ", "Cactus: Light", 1 },
                    { 2, "During the spring and summer, give the cactus water every ten days.During the winter rest period, decrease waterings to once every four weeks. ", "Cactus: Water", 1 },
                    { 3, " Nasturtium grows best in soil with a neutral pH (6 to 8) and can tolerate dry conditions, although a moderate amount of moisture is appreciated. ", "Nasturtium: Soil", 2 },
                    { 4, "Nasturtiums prefer weekly watering, but can be watered more often when planted in a greenhouse or in a sunny vegetable plot", "Nasturium: Water", 2 },
                    { 5, "Nasturtiums grow and bloom best when planted in an area of full sun that receives six to eight hours of direct sunlight daily.", "Nasturium: Light", 2 },
                    { 6, "Give your tea olive shrub at least one inch of water per week, either through rainfall or manual watering methods.", "Tea Olive: Water", 4 },
                    { 7, "Roses like six hours of sun per day, it does matter what part of the day those six hours come from", "Rose: Light", 3 },
                    { 8, "It is best to water roses twice a week—and water them thoroughly. It's better to water deeply twice per week than to water less deeply more often.", "Rose: Water", 3 },
                    { 9, "Roses can survive periodic weather extremes, but they prefer temperatures between 60 and 70 degrees Fahrenheit and a humidity range between 60% and 70%.", "Rose: Temperature", 3 },
                    { 10, "Teddy Bear' sunflower needs full sun; a six to eight hours of bright, direct sunlight daily.", "Teddy bear Sunflower: Light", 5 },
                    { 11, "Teddy Bear' sunflowers need one inch of water weekly depending on rainfall amounts and soil conditions. Avoid overwatering as this can lead to root rot and cause stems to become unstable. ", "Teddy bear Sunflower: Water", 5 },
                    { 12, "Violas prefer sun over shade, but they don't like heat.", "Viola: Light", 6 },
                    { 13, "Pansies and the other violas are best grown in humusy, moist soil, such as a peat-based potting mix, or garden soil heavily amended with organic material. ", "Viola: Soil", 6 },
                    { 14, "Water Viola regularly, but allow the soil to dry out between waterings.", "Viola: Water", 6 },
                    { 15, "Easter lilies prefer to grow in full sun to partial shade, with protection from the strong afternoon sun during the heat of the day", "Easter Lily: Light", 7 },
                    { 16, "Easter lily flowers prefer well-drained soil that’s rich in organic matter, although they'll grow in a variety of soil types as long as the drainage is sufficient.", "Easter Lily: Soil", 7 },
                    { 17, "Easter lilies like evenly moist soil, so whenever the top inch of soil dries out, water the plants until water starts draining from the bottom. Never allow the plants to sit in water, but also don’t let the soil dry out completely.", "Easter Lily: Water", 7 },
                    { 18, "Artichokes require lots of moisture for best growth. Deeply water artichoke plants at planting time, and water them deeply at least once or twice per week.", "Artichoke: Water", 8 },
                    { 19, "Artichokes prefer sandy, well-drained but fertile soil. A soil pH slightly on the alkaline side is best.", "Artichoke: Soil", 8 },
                    { 20, "Fuchsias are happiest with temperatures between 55 and 80 degrees Fahrenheit, though some heat-tolerant cultivars will keep their blooms up to 90 degrees Fahrenheit.", "Fuschsia: Temperature", 9 },
                    { 21, "Fuchsias like to be moist but not soggy. They thrive in humidity, so if you live somewhere dry, they are a little more challenging to grow and keep hydrated.", "Fuschsia: Water", 9 },
                    { 22, ". Water Jalapeño when the soil feels dry about an inch down, but don't allow the soil to become waterlogged.", "Jalapeño: Water", 10 },
                    { 23, "Plant jalapeño peppers in full sun, meaning at least six hours of direct sunlight on most days.", "Jalapeño: Light", 10 },
                    { 24, "A site with partial sun is ideal for shooting star plants.", "Shooting Star: Light", 11 },
                    { 25, "Shooting star plants grow and colonize areas of well-draining or sandy loam, although they will tolerate some clay soils.", "Shooting Star: Soil", 11 },
                    { 26, "Young zebra grass needs regular watering to get established, but a mature specimen will serve as a drought-tolerant ornamental grass.", "Zebra grass: Water", 12 },
                    { 27, "Provide full sun for optimal growth. If the plant is in too much shade, the leaf blades can get floppy, but you can provide a stake or even a tomato cage to help prop them upright.", "Zebra grass: Light", 12 },
                    { 28, "Vanilla bean orchid grows best in shade, but these plants will tolerate short periods of morning sun with indirect light.", "Vanilla Bean Orchid: Light", 13 },
                    { 29, "Watering a vanilla bean orchid means keeping both the growing medium and the wooden trellis structure damp, because the plant is developing \"air roots\" that draw moisture from the air. ", "Vanilla Bean Orchid: Water", 13 },
                    { 30, "The harebell does best when its planted in full sun to partial shade.", "Harebell: Light", 14 },
                    { 31, "These wildflowers like deep, infrequent waters that come from natural rainfall. However, newly established plants benefit from frequent watering.", "Harebell: Water", 14 },
                    { 32, "Well-draining soil is crucially important for the harebell. Consistently moist soil can lead to root rot. ", "Harebell: Soil", 14 },
                    { 33, "While it may be surprising for a plant that grows primarily underground, garlic loves light. To ensure the best chance at growing success, plant your garlic in a spot that receives full sunlight for at least six to eight hours a day.", "Garlic: Light", 15 },
                    { 34, "Garlic doesn't have a ton of water requirements. It generally likes its soil moist and should receive around an inch of water per week, with a slight increase if the weather is especially warm. ", "Garlic: Water", 15 },
                    { 35, "Camellias thrive in partial shade or in locations that receive dappled sunlight for the entire day, such as the understory beneath tall airy trees.", "Camellia: Light", 16 },
                    { 36, "Camellias require well-drained soil, and an ideal soil pH for camellias is within the 6.0 to 6.5 range—slightly acidic.", "Camellia: Soil", 16 },
                    { 37, "Twice-a-week watering for a total of one inch of water per week is a good watering schedule. Apply a three-inch layer of mulch to moderate soil temperatures, retain soil moisture, and stifle weeds.", "Camellia: Water", 16 },
                    { 38, "Water regularly especially during hot weather. Keep soil moist but not waterlogged because these plants are vulnerable to crown rot.", "Delphinium: Water", 17 },
                    { 39, "Delphiniums put on their best show in plenty of sun, 6 to 8 hours daily. However, this is not a plant that does well in dry heat. A location that offers morning sun with light afternoon shade during hot weather can improve and extend flowering.", "Delphinium: Light", 17 },
                    { 40, "Once sprouted, water your dahlias once or twice a week. Make sure to water deeply, as large tubers may be planted six inches deep.", "Dahlia: Water", 18 },
                    { 41, "Dahlias prefer rich, loamy soil with plenty of organic matter that drains well. ", "Dahlia: Soil", 18 },
                    { 42, "Allow the plants to dry between waterings, but not completely. These plants are more susceptible to root rot, so be very careful never to allow them to sit in standing water.", "Dragon Tree: Water", 19 }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "id", "description", "name", "plant_id" },
                values: new object[] { 43, "Dragon tree prefers a very loose, well-drained potting mix. A succulent/cactus potting mix can work well; or you can make your own mix by blending fine gravel, peat moss, and leaf humus in equal parts.", "Dragon Tree: Soil", 19 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "botanical_name", "color", "english_name", "family" },
                values: new object[] { "Capiscum annuum", null, "Jalapeño", "Solanaceae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "botanical_name", "color", "english_name", "family" },
                values: new object[] { "", "", "", "" });
        }
    }
}
