using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dicta_Sanctorum.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Saints",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    feastDay = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    birthYear = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deathYear = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    canonizationYear = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    nationality = table.Column<string>(type: "longtext", nullable: false),
                    bio = table.Column<string>(type: "longtext", nullable: false),
                    image = table.Column<string>(type: "longtext", nullable: false),
                    prayer = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saints", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phrases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    idSaint = table.Column<int>(type: "int", nullable: false),
                    phrase = table.Column<string>(type: "longtext", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
