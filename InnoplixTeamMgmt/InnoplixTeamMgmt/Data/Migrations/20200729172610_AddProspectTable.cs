using Microsoft.EntityFrameworkCore.Migrations;

namespace InnoplixTeamMgmt.Data.Migrations
{
    public partial class AddProspectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prospects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<int>(nullable: false),
                    Ocuupation = table.Column<string>(nullable: true),
                    Income = table.Column<string>(nullable: true),
                    Relation = table.Column<string>(nullable: true),
                    DegreeOfRelation = table.Column<int>(nullable: false),
                    Profile = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prospects");
        }
    }
}
