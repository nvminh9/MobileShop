using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileShop.Data.Migrations
{
    public partial class DbUpdate_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KHUYENMAIs",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    GiamGia = table.Column<float>(type: "real", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHUYENMAIs", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAMs",
                columns: table => new
                {
                    MaLSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiDanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAISANPHAMs", x => x.MaLSP);
                });

            migrationBuilder.CreateTable(
                name: "LOAITHANHVIEN_QUYENs",
                columns: table => new
                {
                    MaLTV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAITHANHVIEN_QUYENs", x => x.MaLTV);
                });

            migrationBuilder.CreateTable(
                name: "LOAITHANHVIENs",
                columns: table => new
                {
                    MaLTV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UuDai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAITHANHVIENs", x => x.MaLTV);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAPs",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHACUNGCAPs", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "NHASANXUATs",
                columns: table => new
                {
                    MaNSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNSX = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ThongTin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Lo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHASANXUATs", x => x.MaNSX);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUNHAPs",
                columns: table => new
                {
                    MaPN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNCC = table.Column<int>(type: "int", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUNHAPs", x => x.MaPN);
                });

            migrationBuilder.CreateTable(
                name: "QUYENs",
                columns: table => new
                {
                    MaQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUYENs", x => x.MaQuyen);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KHUYENMAIs");

            migrationBuilder.DropTable(
                name: "LOAISANPHAMs");

            migrationBuilder.DropTable(
                name: "LOAITHANHVIEN_QUYENs");

            migrationBuilder.DropTable(
                name: "LOAITHANHVIENs");

            migrationBuilder.DropTable(
                name: "NHACUNGCAPs");

            migrationBuilder.DropTable(
                name: "NHASANXUATs");

            migrationBuilder.DropTable(
                name: "PHIEUNHAPs");

            migrationBuilder.DropTable(
                name: "QUYENs");
        }
    }
}
