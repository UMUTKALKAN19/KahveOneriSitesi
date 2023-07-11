using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveOneriSitesi.Migrations
{
    public partial class oneribegeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OneriBegeni",
                table: "Oneris",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneriBegeni",
                table: "Oneris");
        }
    }
}
