using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueAspCoreProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddNoteFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoteName",
                table: "Notes",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "NoteContent",
                table: "Notes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NoteColor",
                table: "Notes",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "NoteId",
                table: "Notes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Notes",
                newName: "NoteName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Notes",
                newName: "NoteContent");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Notes",
                newName: "NoteColor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notes",
                newName: "NoteId");
        }
    }
}
