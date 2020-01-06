using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ItunesSearcher.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppId = table.Column<int>(nullable: false),
                    TrackName = table.Column<string>(nullable: true),
                    Beskrivning = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    AppImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishes");
        }
    }
}
