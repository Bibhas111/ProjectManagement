using Microsoft.EntityFrameworkCore.Migrations;

namespace Epiroc.Data.Entity.Migrations.ProjectDetail
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectDetails",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    ProjectCost = table.Column<string>(nullable: true),
                    ProjectHr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetails", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "ProjectDetails",
                columns: new[] { "ProjectId", "Department", "ProjectCost", "ProjectHr", "ProjectName" },
                values: new object[] { 1, "Construction", "250", "10hr", "abc" });

            migrationBuilder.InsertData(
                table: "ProjectDetails",
                columns: new[] { "ProjectId", "Department", "ProjectCost", "ProjectHr", "ProjectName" },
                values: new object[] { 2, "Construction", "250", "10hr", "abc" });

            migrationBuilder.InsertData(
                table: "ProjectDetails",
                columns: new[] { "ProjectId", "Department", "ProjectCost", "ProjectHr", "ProjectName" },
                values: new object[] { 3, "water-Energy", "250", "10hr", "abc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectDetails");
        }
    }
}
