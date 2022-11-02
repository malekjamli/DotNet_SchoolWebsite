using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnisFinal.Data.Migrations
{
    public partial class _55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_ReportCard_ReportCardId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Domain_pfe",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "ClassNumber",
                table: "Groupe",
                newName: "ClassNumberId");

            migrationBuilder.AddColumn<int>(
                name: "DomainId",
                table: "Teacher",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReportCardId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Domain_pfeDomainId",
                table: "Student",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Domain",
                columns: table => new
                {
                    DomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.DomainId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_DomainId",
                table: "Teacher",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Domain_pfeDomainId",
                table: "Student",
                column: "Domain_pfeDomainId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Domain_Domain_pfeDomainId",
                table: "Student",
                column: "Domain_pfeDomainId",
                principalTable: "Domain",
                principalColumn: "DomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ReportCard_ReportCardId",
                table: "Student",
                column: "ReportCardId",
                principalTable: "ReportCard",
                principalColumn: "ReportCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Domain_DomainId",
                table: "Teacher",
                column: "DomainId",
                principalTable: "Domain",
                principalColumn: "DomainId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groupe_ClassNumber_ClassNumberId",
                table: "Groupe");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Domain_Domain_pfeDomainId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_ReportCard_ReportCardId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Domain_DomainId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "ClassNumber");

            migrationBuilder.DropTable(
                name: "Domain");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_DomainId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Student_Domain_pfeDomainId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Groupe_ClassNumberId",
                table: "Groupe");

            migrationBuilder.DropColumn(
                name: "DomainId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Domain_pfeDomainId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "ClassNumberId",
                table: "Groupe",
                newName: "ClassNumber");

            migrationBuilder.AddColumn<int>(
                name: "Domain",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ReportCardId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Domain_pfe",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ReportCard_ReportCardId",
                table: "Student",
                column: "ReportCardId",
                principalTable: "ReportCard",
                principalColumn: "ReportCardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
