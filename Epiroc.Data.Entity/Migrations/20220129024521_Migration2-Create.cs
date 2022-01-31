using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Epiroc.Data.Entity.Migrations
{
    public partial class Migration2Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectInfos",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    ProjectStaus = table.Column<string>(nullable: true),
                    ProjectstartDt = table.Column<DateTime>(nullable: false),
                    ProjectEnddt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInfos", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "ProjectInfos",
                columns: new[] { "ProjectId", "Department", "ProjectEnddt", "ProjectName", "ProjectStaus", "ProjectstartDt" },
                values: new object[,]
                {
                    { 1, "Construction", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc", "Inprogress", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Construction", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc", "Complete", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Mining", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc", "Inprogress", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Mining", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc", "Complete", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "water-Energy", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc", "Inprogress", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectInfos");
        }
    }
}
