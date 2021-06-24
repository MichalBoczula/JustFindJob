using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class ModifiedRelationBetweenJobOfferAndTechStack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TechStacks_JobOfferId",
                table: "TechStacks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TechStacks_JobOfferId",
                table: "TechStacks",
                column: "JobOfferId",
                unique: true);
        }
    }
}
