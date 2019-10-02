using Microsoft.EntityFrameworkCore.Migrations;

namespace JobAppMS.Migrations
{
    public partial class Myfsfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_PersonalDetails_PersonalID",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_PersonalDetails_PersonalID",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_PersonalDetails_PersonalID",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_PersonalID",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Experience_PersonalID",
                table: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_PersonalID",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PersonalID",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "PersonalID",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "PersonalID",
                table: "Educations");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Experience",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Educations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Educations");

            migrationBuilder.AddColumn<int>(
                name: "PersonalID",
                table: "Training",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalID",
                table: "Experience",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalID",
                table: "Educations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Training_PersonalID",
                table: "Training",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_PersonalID",
                table: "Experience",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonalID",
                table: "Educations",
                column: "PersonalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_PersonalDetails_PersonalID",
                table: "Educations",
                column: "PersonalID",
                principalTable: "PersonalDetails",
                principalColumn: "PersonalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_PersonalDetails_PersonalID",
                table: "Experience",
                column: "PersonalID",
                principalTable: "PersonalDetails",
                principalColumn: "PersonalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_PersonalDetails_PersonalID",
                table: "Training",
                column: "PersonalID",
                principalTable: "PersonalDetails",
                principalColumn: "PersonalID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
