using Microsoft.EntityFrameworkCore.Migrations;

namespace AspProject.Migrations
{
    public partial class BlogSidebarBlogAddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "BlogSidebarBlogs");

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "BlogSidebarBlogs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "BlogSidebarBlogs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heading",
                table: "BlogSidebarBlogs");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "BlogSidebarBlogs");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "BlogSidebarBlogs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
