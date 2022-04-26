using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Data.Migrations
{
    public partial class bill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "BookCategory",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TenHD = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MaSP = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "BookCategory",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
