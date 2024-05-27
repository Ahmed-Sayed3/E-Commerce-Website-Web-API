using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_C_.Migrations
{
    /// <inheritdoc />
    public partial class Itemname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "orderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "orderDetails");
        }
    }
}
