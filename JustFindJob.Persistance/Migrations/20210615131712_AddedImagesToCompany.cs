using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class AddedImagesToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyImage1",
                table: "CompanyDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyImage2",
                table: "CompanyDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyImage3",
                table: "CompanyDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyImage1",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "CompanyImage2",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "CompanyImage3",
                table: "CompanyDetails");
        }
    }
}
