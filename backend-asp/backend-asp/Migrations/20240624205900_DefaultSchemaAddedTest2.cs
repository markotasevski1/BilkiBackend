using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_asp.Migrations
{
    /// <inheritdoc />
    public partial class DefaultSchemaAddedTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "ShopDb",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "ShopDb",
                newName: "BaseUser",
                newSchema: "identity");

            migrationBuilder.AlterColumn<string>(
                name: "Initials",
                schema: "identity",
                table: "BaseUser",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseUser",
                schema: "identity",
                table: "BaseUser",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseUser",
                schema: "identity",
                table: "BaseUser");

            migrationBuilder.RenameTable(
                name: "BaseUser",
                schema: "identity",
                newName: "Users",
                newSchema: "ShopDb");

            migrationBuilder.AlterColumn<string>(
                name: "Initials",
                schema: "ShopDb",
                table: "Users",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "ShopDb",
                table: "Users",
                column: "Id");
        }
    }
}
