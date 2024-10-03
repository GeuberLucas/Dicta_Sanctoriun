using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dicta_Sanctorum.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saints",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    feastDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    birthYear = table.Column<DateTime>(type: "TEXT", nullable: false),
                    deathYear = table.Column<DateTime>(type: "TEXT", nullable: false),
                    canonizationYear = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nationality = table.Column<string>(type: "TEXT", nullable: false),
                    bio = table.Column<string>(type: "TEXT", nullable: false),
                    image = table.Column<string>(type: "TEXT", nullable: false),
                    prayer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saints", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Phrases",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idSaint = table.Column<int>(type: "INTEGER", nullable: false),
                    phrase = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrases", x => x.id);
                    table.ForeignKey(
                        name: "FK_Phrases_Saints_idSaint",
                        column: x => x.idSaint,
                        principalTable: "Saints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_idSaint",
                table: "Phrases",
                column: "idSaint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phrases");

            migrationBuilder.DropTable(
                name: "Saints");
        }
    }
}
