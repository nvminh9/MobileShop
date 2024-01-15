using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class CHITIETSANPHAM
    {
        [Key]
        public int MaCTSP { get; set; }
        public int? MaSP { get; set; }
        public string? DoPhanGiai { get; set; }
        public string? KichThuocManHinh { get; set; }
        public string? DoSangToiDa { get; set; }
        public string? MatKinhCamUng { get; set; }
        public string? QuayPhim { get; set; }
        [MaxLength(10)]
        public string? DenFlash { get; set; }
        public string? TinhNang { get; set; }
        public string? HeDieuHanh { get; set; }
        public string? ChipXuLy { get; set; }
        public string? TocDoCPU { get; set; }
        [MaxLength(10)]
        public string? Ram { get; set; }
        [MaxLength(10)]
        public string? DungLuong { get; set; }
        public string? DanhBa { get; set; }
        public string? MangDiDong { get; set; }
        [MaxLength(50)]
        public string? Sim { get; set; }
        public string? Wifi { get; set; }
        public string? GPS { get; set; }
        [MaxLength(10)]
        public string? Bluetooth { get; set; }
        [MaxLength(10)]
        public string? CongKetNoi { get; set; }
        [MaxLength(10)]
        public string? JackTaiNghe { get; set; }
        [MaxLength(10)]
        public string? LoaiPin { get; set; }
        [MaxLength(10)]
        public string? DungLuongPin { get; set; }
        [MaxLength(10)]
        public string? HoTroSacToiDa { get; set; }
        public string? CongNghePin { get; set; }
        public string? BaoMatNangCao { get; set; }
        public string? TinhNangDacBiet { get; set; }
        public string? KhangNuocBui { get; set; }
        [MaxLength(50)]
        public string? GhiAm { get; set; }
        public string? XemPhim { get; set; }
        public string? NgheNhac { get; set; }
        [MaxLength(50)]
        public string? ThietKe { get; set; }
        [MaxLength(50)]
        public string? ChatLieu { get; set; }
        public string? KichThuocKhoiLuong { get; set; }
        [MaxLength(10)]
        public string? ThoiDiemRaMat { get; set; }
    }
}
