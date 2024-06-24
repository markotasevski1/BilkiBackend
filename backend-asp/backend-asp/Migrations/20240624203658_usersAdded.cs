using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_asp.Migrations
{
    /// <inheritdoc />
    public partial class usersAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "ShopDb");

            migrationBuilder.AddColumn<string>(
                name: "Initials",
                schema: "ShopDb",
                table: "Users",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Initials",
                schema: "ShopDb",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "ShopDb",
                newName: "Users");
        }
    }
}
