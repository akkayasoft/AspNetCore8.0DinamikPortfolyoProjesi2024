using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalismaResim",
                table: "Calismalars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CalismaResim",
                table: "Calismalars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
