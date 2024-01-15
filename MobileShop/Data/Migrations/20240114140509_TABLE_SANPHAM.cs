using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileShop.Data.Migrations
{
    public partial class TABLE_SANPHAM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SANPHAMs",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNCC = table.Column<int>(type: "int", nullable: true),
                    MaNSX = table.Column<int>(type: "int", nullable: true),
                    MaLSP = table.Column<int>(type: "int", nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", precision: 18, scale: 0, nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongBan = table.Column<int>(type: "int", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    LuotXem = table.Column<int>(type: "int", nullable: true),
                    LuotBinhChon = table.Column<int>(type: "int", nullable: true),
                    LuotBinhLuan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Moi = table.Column<int>(type: "int", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAMs", x => x.MaSP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SANPHAMs");
        }
    }
}
