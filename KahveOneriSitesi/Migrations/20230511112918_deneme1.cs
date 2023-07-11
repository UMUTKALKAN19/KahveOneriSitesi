using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveOneriSitesi.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminKadi = table.Column<string>(maxLength: 20, nullable: true),
                    AdminSifre = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Kahvelers",
                columns: table => new
                {
                    KahveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KahveAd = table.Column<int>(nullable: false),
                    KahveMalzeme = table.Column<int>(nullable: false),
                    KahveTarif = table.Column<int>(nullable: false),
                    KahveResim = table.Column<int>(nullable: false),
                    KahveTur = table.Column<int>(nullable: false),
                    KahveTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kahvelers", x => x.KahveID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajGonderen = table.Column<string>(maxLength: 30, nullable: false),
                    MesajBaslik = table.Column<string>(maxLength: 50, nullable: false),
                    MesajMail = table.Column<string>(maxLength: 50, nullable: false),
                    MesajIcerik = table.Column<string>(maxLength: 300, nullable: false),
                    MesajTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumSahip = table.Column<string>(maxLength: 30, nullable: false),
                    YorumMail = table.Column<string>(maxLength: 50, nullable: false),
                    YorumTarih = table.Column<DateTime>(nullable: false),
                    YorumOnay = table.Column<bool>(nullable: false),
                    YorumIcerik = table.Column<string>(maxLength: 300, nullable: false),
                    KahveID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_Kahvelers_KahveID",
                        column: x => x.KahveID,
                        principalTable: "Kahvelers",
                        principalColumn: "KahveID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_KahveID",
                table: "Yorumlars",
                column: "KahveID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Mesajlars");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "Kahvelers");
        }
    }
}
