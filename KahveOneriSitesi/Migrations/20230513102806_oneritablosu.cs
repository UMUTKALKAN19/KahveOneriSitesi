using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveOneriSitesi.Migrations
{
    public partial class oneritablosu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oneris",
                columns: table => new
                {
                    OneriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OneriAd = table.Column<string>(nullable: true),
                    OneriMalzeme = table.Column<string>(nullable: true),
                    OneriTarif = table.Column<string>(nullable: true),
                    OneriResim = table.Column<string>(nullable: true),
                    OneriTur = table.Column<bool>(nullable: false),
                    OneriTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oneris", x => x.OneriID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oneris");
        }
    }
}
