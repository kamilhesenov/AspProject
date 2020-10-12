using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspProject.Migrations
{
    public partial class BaseEntityAddedDateColumnDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "ServicePromos");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "PageFaqPromos");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "OurWorkProcesses");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "HomeServiceItems");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "HomePortfolioItems");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "AboutPromos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "HomeOurNewsItems",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "BlogSidebarBlogs",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "BlogSidebarBlogItems",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "BlogSidebarBlogItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Testimonials",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "ServicePromos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Promos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "PageFaqPromos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "OurWorkProcesses",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "HomeServiceItems",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "HomePortfolioItems",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "HomeOurNewsItems",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Heroes",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "BlogSidebarBlogs",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "AboutUs",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Abouts",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "AboutPromos",
                type: "date",
                nullable: true);
        }
    }
}
