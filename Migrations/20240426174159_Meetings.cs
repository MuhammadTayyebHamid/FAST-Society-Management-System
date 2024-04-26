using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE_Project.Migrations
{
    /// <inheritdoc />
    public partial class Meetings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingTopic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Society = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    starttime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endtime = table.Column<TimeSpan>(type: "time", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meetings");
        }
    }
}
