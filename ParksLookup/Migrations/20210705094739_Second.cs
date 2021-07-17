using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkLookup.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Coordinates",
                table: "Parks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Coordinates", "Established", "Name", "Province" },
                values: new object[,]
                {
                    { 1, 0, 2020, "Himalaya National Park", "GB" },
                    { 2, 0, 2012, "Hundrap-Shandur National Park", "GB" },
                    { 3, 0, 2010, "Nanga-Parbat National Park", "GB" },
                    { 4, 0, 1993, "Broghil Valley", "KP" },
                    { 5, 0, 1987, "Central Karakoram", "GB" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "Parks");
        }
    }
}
