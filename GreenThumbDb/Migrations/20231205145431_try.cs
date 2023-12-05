using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbDb.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "BETzSRAPc3/w6srQ6jx5bw==");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "password", "user_name" },
                values: new object[] { 2, "BETzSRAPc3/w6srQ6jx5bw==", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "+DRFZc6gI+vGZ9T/iS4wGQ==");
        }
    }
}
