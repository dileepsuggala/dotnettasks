using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcwebappdemo.Migrations
{
    public partial class createintials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Btitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Authorname = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    Releasedate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Bid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
