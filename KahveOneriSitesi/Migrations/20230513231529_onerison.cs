using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveOneriSitesi.Migrations
{
    public partial class onerison : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OneriDurum",
                table: "Oneris",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneriDurum",
                table: "Oneris");
        }
    }
}
