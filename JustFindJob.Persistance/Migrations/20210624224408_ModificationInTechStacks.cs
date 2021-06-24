using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class ModificationInTechStacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TechStacks",
                table: "TechStacks");

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TechStacks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TechStacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "TechStacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "TechStacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "TechStacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "TechStacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechStacks",
                table: "TechStacks",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TechStacks",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "JobOfferId", "Modified", "ModifiedBy", "StatusId", "TechnologyElementId", "TechnologyLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1, null, null, 0, 1, 2 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7, null, null, 0, 4, 3 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, null, 0, 15, 2 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, null, 0, 4, 2 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, null, 0, 8, 2 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, null, 0, 9, 1 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, null, 0, 10, 1 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, null, 0, 15, 3 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, null, 0, 4, 3 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, null, 0, 8, 3 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, null, 0, 9, 3 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, null, 0, 10, 3 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, null, 0, 2, 3 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, null, 0, 4, 3 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, null, 0, 8, 3 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, null, 0, 9, 3 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, null, 0, 10, 3 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11, null, null, 0, 13, 3 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11, null, null, 0, 14, 3 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11, null, null, 0, 5, 3 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12, null, null, 0, 6, 2 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12, null, null, 0, 5, 2 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7, null, null, 0, 8, 3 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7, null, null, 0, 2, 2 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7, null, null, 0, 15, 3 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 5, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1, null, null, 0, 3, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1, null, null, 0, 4, 2 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2, null, null, 0, 1, 3 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2, null, null, 0, 2, 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2, null, null, 0, 3, 3 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2, null, null, 0, 4, 3 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3, null, null, 0, 1, 3 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3, null, null, 0, 4, 3 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3, null, null, 0, 3, 3 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4, null, null, 0, 3, 4 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12, null, null, 0, 11, 2 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4, null, null, 0, 6, 4 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4, null, null, 0, 5, 4 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5, null, null, 0, 3, 4 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5, null, null, 0, 6, 4 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5, null, null, 0, 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "TechStacks",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "JobOfferId", "Modified", "ModifiedBy", "StatusId", "TechnologyElementId", "TechnologyLevelId" },
                values: new object[,]
                {
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5, null, null, 0, 5, 4 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 3, 2 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 4, 1 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 8, 1 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 6, 2 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, null, 0, 7, 2 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4, null, null, 0, 7, 4 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12, null, null, 0, 12, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechStacks_JobOfferId",
                table: "TechStacks",
                column: "JobOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TechStacks",
                table: "TechStacks");

            migrationBuilder.DropIndex(
                name: "IX_TechStacks_JobOfferId",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "TechStacks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechStacks",
                table: "TechStacks",
                columns: new[] { "JobOfferId", "TechnologyElementId" });
        }
    }
}
