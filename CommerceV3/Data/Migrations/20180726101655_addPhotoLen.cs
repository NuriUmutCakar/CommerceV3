using Microsoft.EntityFrameworkCore.Migrations;

namespace CommerceV3.Data.Migrations
{
    public partial class addPhotoLen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Products",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Products",
                nullable: true);
        }
    }
}
