using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class ModifiedModelAndConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgrammingLanguageId",
                table: "TechnologyElements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TechnologyElements_ProgrammingLanguageId",
                table: "TechnologyElements",
                column: "ProgrammingLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnologyElements_ProgrammingLanguages_ProgrammingLanguageId",
                table: "TechnologyElements",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechnologyElements_ProgrammingLanguages_ProgrammingLanguageId",
                table: "TechnologyElements");

            migrationBuilder.DropIndex(
                name: "IX_TechnologyElements_ProgrammingLanguageId",
                table: "TechnologyElements");

            migrationBuilder.DropColumn(
                name: "ProgrammingLanguageId",
                table: "TechnologyElements");
        }
    }
}
