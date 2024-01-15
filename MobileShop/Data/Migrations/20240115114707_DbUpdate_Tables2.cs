using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileShop.Data.Migrations
{
    public partial class DbUpdate_Tables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BINHLUANs",
                columns: table => new
                {
                    MaBL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTV = table.Column<int>(type: "int", nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    NoiDungBL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BINHLUANs", x => x.MaBL);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETDONDATHANGs",
                columns: table => new
                {
                    MaCTDDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDDH = table.Column<int>(type: "int", nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", precision: 18, scale: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETDONDATHANGs", x => x.MaCTDDH);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETPHIEUNHAPs",
                columns: table => new
                {
                    MaCTPN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPN = table.Column<int>(type: "int", nullable: true),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    DonGiaNhap = table.Column<decimal>(type: "decimal(18,0)", precision: 18, scale: 0, nullable: true),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETPHIEUNHAPs", x => x.MaCTPN);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETSANPHAMs",
                columns: table => new
                {
                    MaCTSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<int>(type: "int", nullable: true),
                    DoPhanGiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KichThuocManHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoSangToiDa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKinhCamUng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuayPhim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DenFlash = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TinhNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChipXuLy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TocDoCPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DungLuong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DanhBa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MangDiDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Wifi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bluetooth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CongKetNoi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    JackTaiNghe = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LoaiPin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DungLuongPin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HoTroSacToiDa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CongNghePin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaoMatNangCao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhNangDacBiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhangNuocBui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiAm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    XemPhim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgheNhac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThietKe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KichThuocKhoiLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiDiemRaMat = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETSANPHAMs", x => x.MaCTSP);
                });

            migrationBuilder.CreateTable(
                name: "DONDATHANGs",
                columns: table => new
                {
                    MaDDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<int>(type: "int", nullable: true),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TinhTrangGiao = table.Column<bool>(type: "bit", nullable: true),
                    NgayGiao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaThanhToan = table.Column<bool>(type: "bit", nullable: true),
                    UuDai = table.Column<int>(type: "int", nullable: true),
                    DaHuy = table.Column<bool>(type: "bit", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONDATHANGs", x => x.MaDDH);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANGs",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTV = table.Column<int>(type: "int", nullable: true),
                    TenKH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANGs", x => x.MaKH);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BINHLUANs");

            migrationBuilder.DropTable(
                name: "CHITIETDONDATHANGs");

            migrationBuilder.DropTable(
                name: "CHITIETPHIEUNHAPs");

            migrationBuilder.DropTable(
                name: "CHITIETSANPHAMs");

            migrationBuilder.DropTable(
                name: "DONDATHANGs");

            migrationBuilder.DropTable(
                name: "KHACHHANGs");
        }
    }
}
