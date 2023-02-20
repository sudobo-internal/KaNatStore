using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanatStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhân viên",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCCD = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Sốngàylàm = table.Column<double>(name: "Số ngày làm", type: "float", nullable: false),
                    Thưởng = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Hệsốlương = table.Column<decimal>(name: "Hệ số lương", type: "decimal(18,0)", nullable: false),
                    Tổnglương = table.Column<decimal>(name: "Tổng lương", type: "decimal(18,0)", nullable: false),
                    Họvàtên = table.Column<string>(name: "Họ và tên", type: "nvarchar(50)", nullable: false),
                    Ngàysinh = table.Column<DateTime>(name: "Ngày sinh", type: "DateTime", nullable: false),
                    Giớitính = table.Column<string>(name: "Giới tính", type: "nvarchar(10)", nullable: false),
                    Địachỉ = table.Column<string>(name: "Địa chỉ", type: "nvarchar(100)", nullable: false),
                    Sốđiệnthoại = table.Column<string>(name: "Số điện thoại", type: "nvarchar(12)", nullable: false),
                    Loạiđốitượng = table.Column<string>(name: "Loại đối tượng", type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhân viên", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhân viên");
        }
    }
}
