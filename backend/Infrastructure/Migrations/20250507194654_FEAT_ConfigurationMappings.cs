using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FEAT_ConfigurationMappings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroSuperPowerEntity_Heroes_HeroId",
                table: "HeroSuperPowerEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroSuperPowerEntity_SuperPowerEntity_SuperPowerId",
                table: "HeroSuperPowerEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperPowerEntity",
                table: "SuperPowerEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroSuperPowerEntity",
                table: "HeroSuperPowerEntity");

            migrationBuilder.DropIndex(
                name: "IX_HeroSuperPowerEntity_HeroId",
                table: "HeroSuperPowerEntity");

            migrationBuilder.DropIndex(
                name: "IX_HeroSuperPowerEntity_SuperPowerId",
                table: "HeroSuperPowerEntity");

            migrationBuilder.RenameTable(
                name: "SuperPowerEntity",
                newName: "SuperPowers");

            migrationBuilder.RenameTable(
                name: "HeroSuperPowerEntity",
                newName: "HeroSuperPowers");

            migrationBuilder.AlterColumn<string>(
                name: "SuperPower",
                table: "SuperPowers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SuperPowers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "SuperPowers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "HeroSuperPowers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperPowers",
                table: "SuperPowers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroSuperPowers",
                table: "HeroSuperPowers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_Deleted",
                table: "SuperPowers",
                column: "Deleted")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowers_Deleted",
                table: "HeroSuperPowers",
                column: "Deleted")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowers_HeroId",
                table: "HeroSuperPowers",
                column: "HeroId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowers_SuperPowerId",
                table: "HeroSuperPowers",
                column: "SuperPowerId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroSuperPowers_Heroes_HeroId",
                table: "HeroSuperPowers",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroSuperPowers_SuperPowers_SuperPowerId",
                table: "HeroSuperPowers",
                column: "SuperPowerId",
                principalTable: "SuperPowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroSuperPowers_Heroes_HeroId",
                table: "HeroSuperPowers");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroSuperPowers_SuperPowers_SuperPowerId",
                table: "HeroSuperPowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperPowers",
                table: "SuperPowers");

            migrationBuilder.DropIndex(
                name: "IX_SuperPowers_Deleted",
                table: "SuperPowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroSuperPowers",
                table: "HeroSuperPowers");

            migrationBuilder.DropIndex(
                name: "IX_HeroSuperPowers_Deleted",
                table: "HeroSuperPowers");

            migrationBuilder.DropIndex(
                name: "IX_HeroSuperPowers_HeroId",
                table: "HeroSuperPowers");

            migrationBuilder.DropIndex(
                name: "IX_HeroSuperPowers_SuperPowerId",
                table: "HeroSuperPowers");

            migrationBuilder.RenameTable(
                name: "SuperPowers",
                newName: "SuperPowerEntity");

            migrationBuilder.RenameTable(
                name: "HeroSuperPowers",
                newName: "HeroSuperPowerEntity");

            migrationBuilder.AlterColumn<string>(
                name: "SuperPower",
                table: "SuperPowerEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SuperPowerEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "SuperPowerEntity",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "HeroSuperPowerEntity",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperPowerEntity",
                table: "SuperPowerEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroSuperPowerEntity",
                table: "HeroSuperPowerEntity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowerEntity_HeroId",
                table: "HeroSuperPowerEntity",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPowerEntity_SuperPowerId",
                table: "HeroSuperPowerEntity",
                column: "SuperPowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroSuperPowerEntity_Heroes_HeroId",
                table: "HeroSuperPowerEntity",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroSuperPowerEntity_SuperPowerEntity_SuperPowerId",
                table: "HeroSuperPowerEntity",
                column: "SuperPowerId",
                principalTable: "SuperPowerEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
