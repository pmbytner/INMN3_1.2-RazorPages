using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INMN3_1._2_RazorPages.Migrations
{
    public partial class NowaKolumnaWojewództwa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Województwo",
                table: "Miasta",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Województwo",
                table: "Miasta");
        }
    }
}
