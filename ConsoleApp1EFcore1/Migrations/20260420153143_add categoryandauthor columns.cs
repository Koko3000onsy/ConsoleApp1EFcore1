using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1EFcore1.Migrations
{
    /// <inheritdoc />
    public partial class addcategoryandauthorcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorIDId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryIdId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorIDId",
                table: "Books",
                column: "AuthorIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryIdId",
                table: "Books",
                column: "CategoryIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorIDId",
                table: "Books",
                column: "AuthorIDId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryIdId",
                table: "Books",
                column: "CategoryIdId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorIDId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryIdId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorIDId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryIdId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthorIDId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryIdId",
                table: "Books");
        }
    }
}
