using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspProject.Migrations
{
    public partial class HomePageCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: false),
                    Heading = table.Column<string>(maxLength: 50, nullable: false),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DownloadApps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadApps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DownloadAppStors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadAppStors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Heading = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeCallToActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeCallToActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeOurNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeOurNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeOurNewsItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false),
                    Label = table.Column<string>(maxLength: 50, nullable: false),
                    Heading = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeOurNewsItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePortfolioItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Heading = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePortfolioItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePortfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePortfolios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeServiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Info = table.Column<string>(maxLength: 200, nullable: false),
                    MainIcon = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServiceItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTeamTwoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(maxLength: 300, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false),
                    Facebook = table.Column<string>(maxLength: 100, nullable: false),
                    Linkedin = table.Column<string>(maxLength: 100, nullable: false),
                    Dribbble = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTeamTwoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTeamTwos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTeamTwos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    Facebook = table.Column<string>(maxLength: 100, nullable: false),
                    Twitter = table.Column<string>(maxLength: 100, nullable: false),
                    Linkedin = table.Column<string>(maxLength: 100, nullable: false),
                    Dribbble = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestemonialItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false),
                    Text = table.Column<string>(maxLength: 500, nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false),
                    Star = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestemonialItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Content = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "DownloadApps");

            migrationBuilder.DropTable(
                name: "DownloadAppStors");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "HomeCallToActions");

            migrationBuilder.DropTable(
                name: "HomeOurNews");

            migrationBuilder.DropTable(
                name: "HomeOurNewsItems");

            migrationBuilder.DropTable(
                name: "HomePortfolioItems");

            migrationBuilder.DropTable(
                name: "HomePortfolios");

            migrationBuilder.DropTable(
                name: "HomeServiceItems");

            migrationBuilder.DropTable(
                name: "HomeServices");

            migrationBuilder.DropTable(
                name: "HomeTeamTwoItems");

            migrationBuilder.DropTable(
                name: "HomeTeamTwos");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "TestemonialItems");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
