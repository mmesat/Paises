using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paises.Migrations
{
    public partial class ajusteCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Languaje",
                table: "Countries",
                newName: "Language");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Countries",
                newName: "Languaje");
        }
    }
}
