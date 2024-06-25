using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calismalars",
                columns: table => new
                {
                    CalismaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalismaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalismaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalismaResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calismalars", x => x.CalismaId);
                });

            migrationBuilder.CreateTable(
                name: "Ekips",
                columns: table => new
                {
                    EkipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkipAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkipAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EkipResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekips", x => x.EkipId);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    HakkimizdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimizdaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.HakkimizdaId);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calismalars");

            migrationBuilder.DropTable(
                name: "Ekips");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
