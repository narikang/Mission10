using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission10.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    teamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    teamName = table.Column<string>(type: "TEXT", nullable: false),
                    captainID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.teamID);
                });

            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    bowlerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    bowlerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: true),
                    bowlerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerCity = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerState = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerZip = table.Column<string>(type: "TEXT", nullable: false),
                    bowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    teamID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.bowlerID);
                    table.ForeignKey(
                        name: "FK_Bowlers_Teams_teamID",
                        column: x => x.teamID,
                        principalTable: "Teams",
                        principalColumn: "teamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bowlers_teamID",
                table: "Bowlers",
                column: "teamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
