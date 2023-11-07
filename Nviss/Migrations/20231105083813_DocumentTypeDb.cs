using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nviss.Migrations
{
    /// <inheritdoc />
    public partial class DocumentTypeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "MailTrackers");

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "MailTrackers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MailTrackers_DocumentId",
                table: "MailTrackers",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MailTrackers_Documents_DocumentId",
                table: "MailTrackers",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailTrackers_Documents_DocumentId",
                table: "MailTrackers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_MailTrackers_DocumentId",
                table: "MailTrackers");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "MailTrackers");

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "MailTrackers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
