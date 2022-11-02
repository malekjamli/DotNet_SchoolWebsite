using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnisFinal.Data.Migrations
{
    public partial class _66 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groupe_ClassNumber_ClassNumberId",
                table: "Groupe");

            migrationBuilder.DropTable(
                name: "ClassNumber");

            migrationBuilder.DropIndex(
                name: "IX_Groupe_ClassNumberId",
                table: "Groupe");

            migrationBuilder.DropColumn(
                name: "ClassNumberId",
                table: "Groupe");

            migrationBuilder.AddColumn<string>(
                name: "ClassNumber",
                table: "Groupe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassNumber",
                table: "Groupe");

            migrationBuilder.AddColumn<int>(
                name: "ClassNumberId",
                table: "Groupe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassNumber",
                columns: table => new
                {
                    ClassNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassNumber", x => x.ClassNumberId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groupe_ClassNumberId",
                table: "Groupe",
                column: "ClassNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groupe_ClassNumber_ClassNumberId",
                table: "Groupe",
                column: "ClassNumberId",
                principalTable: "ClassNumber",
                principalColumn: "ClassNumberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
