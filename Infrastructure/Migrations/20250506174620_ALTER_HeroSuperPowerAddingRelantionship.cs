using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ALTER_HeroSuperPowerAddingRelantionship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperPowerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowerEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroSuperPowerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    SuperPowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSuperPowerEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroSuperPowerEntity_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroSuperPowerEntity_SuperPowerEntity_SuperPowerId",
                        column: x => x.SuperPowerId,
                        principalTable: "SuperPowerEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowerEntity_HeroId",
                table: "HeroSuperPowerEntity",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowerEntity_SuperPowerId",
                table: "HeroSuperPowerEntity",
                column: "SuperPowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroSuperPowerEntity");

            migrationBuilder.DropTable(
                name: "SuperPowerEntity");
        }
    }
}
