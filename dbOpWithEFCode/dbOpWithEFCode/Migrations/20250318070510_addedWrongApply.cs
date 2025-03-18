using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbOpWithEFCode.Migrations
{
    /// <inheritdoc />
    public partial class addedWrongApply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Books");
        }
    }
}
