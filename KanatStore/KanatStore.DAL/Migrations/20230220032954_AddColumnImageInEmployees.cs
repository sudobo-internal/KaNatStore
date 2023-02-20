using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanatStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnImageInEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ảnh",
                table: "Nhân viên",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ảnh",
                table: "Nhân viên");
        }
    }
}
