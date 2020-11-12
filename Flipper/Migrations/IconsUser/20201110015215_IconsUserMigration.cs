using Microsoft.EntityFrameworkCore.Migrations;

namespace Flipper.Migrations.IconsUser
{
    public partial class IconsUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IconsUser",
                columns: table => new
                {
                    IdIconUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconsUser", x => x.IdIconUser);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IconsUser");
        }
    }
}
