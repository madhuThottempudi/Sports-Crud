using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsApplication.Migrations
{
    public partial class football : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballClubs",
                columns: table => new
                {
                    Player_Id = table.Column<int>(type: "int", nullable: false),
                    Club_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballClubs", x => x.Player_Id);
                });

            migrationBuilder.CreateTable(
                name: "Footballs",
                columns: table => new
                {
                    Player_Id = table.Column<int>(type: "int", nullable: false),
                    Player_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tropies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footballs", x => x.Player_Id);
                    table.ForeignKey(
                        name: "FK_Footballs_FootballClubs_PlayerRefId",
                        column: x => x.PlayerRefId,
                        principalTable: "FootballClubs",
                        principalColumn: "Player_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Footballs_PlayerRefId",
                table: "Footballs",
                column: "PlayerRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footballs");

            migrationBuilder.DropTable(
                name: "FootballClubs");
        }
    }
}
