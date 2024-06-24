using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_asp.Migrations
{
    /// <inheritdoc />
    public partial class DefaultSchemaAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "ShoppingCart",
                newSchema: "identity");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Order",
                newSchema: "identity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                schema: "identity",
                newName: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "identity",
                newName: "Order");
        }
    }
}
