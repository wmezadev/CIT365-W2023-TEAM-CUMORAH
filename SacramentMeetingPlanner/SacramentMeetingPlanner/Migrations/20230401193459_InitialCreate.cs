using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningSong = table.Column<int>(type: "int", nullable: true),
                    OpeningPray = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymn = table.Column<int>(type: "int", nullable: true),
                    SpeakerSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingSong = table.Column<int>(type: "int", nullable: true),
                    ClosingPray = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
