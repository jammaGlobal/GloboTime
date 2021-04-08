using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace timeZoneApp.Migrations
{
    public partial class CreateRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    offset = table.Column<TimeSpan>(type: "time", nullable: false),
                    offsetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mostRecentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
