using Microsoft.EntityFrameworkCore.Migrations;

namespace Flipper.Migrations.IconsGroup
{
    public partial class IconsGroupMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IconsGroup",
                columns: table => new
                {
                    IdIconGroup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: false),
                    IdGame = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconsGroup", x => x.IdIconGroup);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IconsGroup");
        }
    }
}
