using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveOneriSitesi.Migrations
{
    public partial class oneriguncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnerenAdSoyad",
                table: "Oneris",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnerenAdSoyad",
                table: "Oneris");
        }
    }
}
