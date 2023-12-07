using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbDb.Migrations
{
    public partial class seedmoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "Plants");

            migrationBuilder.InsertData(
                table: "GardenPlants",
                columns: new[] { "garden_id", "plant_id" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "BETzSRAPc3/w6srQ6jx5bw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GardenPlants",
                keyColumns: new[] { "garden_id", "plant_id" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "BETzSRAPc3/w6srQ6jx5bw==");
        }
    }
}
