using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OlympicsWebsite.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "po", "Paralympics" },
                    { "so", "Summer Olympics" },
                    { "wo", "Winter Olympics" },
                    { "yo", "Youth Olympics" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Category", "Name" },
                values: new object[,]
                {
                    { "arch", "Indoor", "Archery" },
                    { "bobsl", "Outdoor", "Bobsleigh" },
                    { "brkdnc", "Indoor", "Breakdancing" },
                    { "canoe", "Outdoor", "Canoe Sprint" },
                    { "curl", "Indoor", "Curling" },
                    { "cycl", "Outdoor", "Road Cycling" },
                    { "dive", "Indoor", "Diving" },
                    { "skbrd", "Outdoor", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryImage", "GameID", "Name", "SportID" },
                values: new object[,]
                {
                    { "aus", "Austria.png", "po", "Austria", "canoe" },
                    { "bra", "Brazil.png", "so", "Brazil", "cycl" },
                    { "can", "Canada.png", "wo", "Canada", "curl" },
                    { "chn", "China.png", "so", "China", "dive" },
                    { "cyp", "Cyprus.png", "yo", "Cyprus", "brkdnc" },
                    { "fin", "Finland.png", "yo", "Finland", "skbrd" },
                    { "fra", "France.png", "yo", "France", "brkdnc" },
                    { "gbr", "GreatBritain.png", "wo", "Great Britain", "curl" },
                    { "ger", "Germany.png", "so", "Germany", "dive" },
                    { "ita", "Italy.png", "wo", "Italy", "bobsl" },
                    { "jam", "Jamaica.png", "wo", "Jamaica", "bobsl" },
                    { "jpn", "Japan.png", "wo", "Japan", "bobsl" },
                    { "mex", "Mexico.png", "so", "Mexico", "dive" },
                    { "ned", "Netherlands.png", "so", "Netherlands", "cycl" },
                    { "pak", "Pakistan.png", "po", "Pakistan", "canoe" },
                    { "por", "Portugal.png", "yo", "Portugal", "skbrd" },
                    { "rus", "Russia.png", "yo", "Russia", "brkdnc" },
                    { "svk", "Slovakia.png", "yo", "Slovakia", "skbrd" },
                    { "swe", "Sweden.png", "wo", "Sweden", "curl" },
                    { "tha", "Thailand.png", "po", "Thailand", "arch" },
                    { "ukr", "Ukraine.png", "po", "Ukraine", "arch" },
                    { "uru", "Uruguay.png", "po", "Uruguay", "arch" },
                    { "usa", "USA.png", "so", "USA", "cycl" },
                    { "zim", "Zimbabwe.png", "po", "Zimbabwe", "canoe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
