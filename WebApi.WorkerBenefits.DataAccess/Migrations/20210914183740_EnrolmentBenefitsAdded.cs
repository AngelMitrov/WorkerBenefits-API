using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.WorkerBenefits.DataAccess.Migrations
{
    public partial class EnrolmentBenefitsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BenefitId",
                table: "TechnologyTypeEnrolments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BenefitId",
                table: "JobPositionEnrolments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BenefitId",
                table: "IndividualEnrolments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TechnologyTypeEnrolments_BenefitId",
                table: "TechnologyTypeEnrolments",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPositionEnrolments_BenefitId",
                table: "JobPositionEnrolments",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualEnrolments_BenefitId",
                table: "IndividualEnrolments",
                column: "BenefitId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualEnrolments_Benefits_BenefitId",
                table: "IndividualEnrolments",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositionEnrolments_Benefits_BenefitId",
                table: "JobPositionEnrolments",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnologyTypeEnrolments_Benefits_BenefitId",
                table: "TechnologyTypeEnrolments",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualEnrolments_Benefits_BenefitId",
                table: "IndividualEnrolments");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPositionEnrolments_Benefits_BenefitId",
                table: "JobPositionEnrolments");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnologyTypeEnrolments_Benefits_BenefitId",
                table: "TechnologyTypeEnrolments");

            migrationBuilder.DropIndex(
                name: "IX_TechnologyTypeEnrolments_BenefitId",
                table: "TechnologyTypeEnrolments");

            migrationBuilder.DropIndex(
                name: "IX_JobPositionEnrolments_BenefitId",
                table: "JobPositionEnrolments");

            migrationBuilder.DropIndex(
                name: "IX_IndividualEnrolments_BenefitId",
                table: "IndividualEnrolments");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "TechnologyTypeEnrolments");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "JobPositionEnrolments");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "IndividualEnrolments");
        }
    }
}
