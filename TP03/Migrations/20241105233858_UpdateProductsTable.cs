using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP03SWII6.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "produto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "produto");
        }
    }
}
