using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBlazorEF.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "22ced2e2-ff02-4fdb-b690-292df3eecef7", "Jane", "Smith", "Medicine" },
                    { "733548c4-aa07-40e7-bb79-737fb91a32fd", "John", "Fisher", "Engineering" },
                    { "48c713d5-0609-47ea-a0f8-7a962ffc0232", "Pamela", "Baker", "Food Science" },
                    { "48eb4c23-c8af-420c-950d-f74be1a43b98", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
