using Microsoft.EntityFrameworkCore.Migrations;

namespace AspProject.Migrations
{
    public partial class AboutItemTableAddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Abouts");

            migrationBuilder.AddColumn<byte>(
                name: "Count",
                table: "AboutItems",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "AboutItems",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "AboutItems");

            migrationBuilder.AddColumn<byte>(
                name: "Count",
                table: "Abouts",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Abouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
