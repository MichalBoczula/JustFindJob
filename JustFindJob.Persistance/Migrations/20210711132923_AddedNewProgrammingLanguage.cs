using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class AddedNewProgrammingLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Created", "CreatedBy", "Image", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "SQL", 0 });

            migrationBuilder.UpdateData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProgrammingLanguageId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProgrammingLanguageId",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProgrammingLanguageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProgrammingLanguageId",
                value: null);
        }
    }
}
