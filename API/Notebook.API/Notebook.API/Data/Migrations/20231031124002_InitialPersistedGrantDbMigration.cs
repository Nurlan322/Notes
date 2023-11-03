using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notebook.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialPersistedGrantDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NoteTitle = table.Column<string>(type: "text", nullable: false),
                    NoteText = table.Column<string>(type: "text", nullable: false),
                    NoteTag = table.Column<string>(type: "text", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");
        }
    }
}
