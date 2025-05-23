using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SynopsisId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Synopses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synopses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_SynopsisId",
                table: "Books",
                column: "SynopsisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Synopses_SynopsisId",
                table: "Books",
                column: "SynopsisId",
                principalTable: "Synopses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Synopses_SynopsisId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Synopses");

            migrationBuilder.DropIndex(
                name: "IX_Books_SynopsisId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SynopsisId",
                table: "Books");
        }
    }
}
