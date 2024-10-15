using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueAspCoreProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixNoteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NoteColor",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteColor",
                table: "Notes");
        }
    }
}
