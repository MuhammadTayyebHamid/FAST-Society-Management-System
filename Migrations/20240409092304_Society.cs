using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE_Project.Migrations
{
    /// <inheritdoc />
    public partial class Society : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MentorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Head = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plans = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Societies");
        }
    }
}
