using Microsoft.EntityFrameworkCore.Migrations;

namespace InnoplixTeamMgmt.Data.Migrations
{
    public partial class AlterProspectTableForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProspectType",
                table: "Prospects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Prospects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_UserName",
                table: "Prospects",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Prospects_AspNetUsers_UserName",
                table: "Prospects",
                column: "UserName",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prospects_AspNetUsers_UserName",
                table: "Prospects");

            migrationBuilder.DropIndex(
                name: "IX_Prospects_UserName",
                table: "Prospects");

            migrationBuilder.DropColumn(
                name: "ProspectType",
                table: "Prospects");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Prospects");
        }
    }
}
