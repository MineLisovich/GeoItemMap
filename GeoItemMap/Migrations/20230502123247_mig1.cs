using Microsoft.EntityFrameworkCore.Migrations;

namespace GeoItemMap.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GeoItems",
                columns: new[] { "Id", "Description", "X", "Y" },
                values: new object[] { 1, "Какой-то текст", 34.439999999999998, 56.43 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeoItems");
        }
    }
}
