using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INMN3_1._2_RazorPages.Migrations
{
    public partial class Pierwotna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Miasta",
                columns: table => new
                {
                    Id = table.Column<int>(
                        type: "int",
                        nullable: false
                        )
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                        ),
                    Populacja = table.Column<long>(
                        type: "bigint",
                        nullable: false
                        ),
                    Powierzchnia = table.Column<decimal>(
                        type: "decimal(18,2)",
                        nullable: false
                        ),
                    DataZałożenia = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: false
                        )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miasta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Miasta");
        }
    }
}
