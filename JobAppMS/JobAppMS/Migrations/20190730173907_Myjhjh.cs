using Microsoft.EntityFrameworkCore.Migrations;

namespace JobAppMS.Migrations
{
    public partial class Myjhjh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "JobApplication",
                newName: "PhoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "JobApplication",
                newName: "Password");
        }
    }
}
