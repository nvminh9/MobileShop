using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Data
{
    [Table("SANPHAMs")]
    public class SANPHAM
    {
        [Key]
        public int MaSP { get; set; }
        public int? MaNCC { get; set; }
        public int? MaNSX { get; set; }
        public int? MaLSP { get; set; }
        public string? TenSP { get; set; }
        [Precision(18,0)]
        public decimal? DonGia { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? MoTa { get; set; }
        public string? HinhChinh { get; set; }
        public string? Hinh1 { get; set; }
        public string? Hinh2 { get; set; }
        public string? Hinh3 { get; set; }
        public int? SoLuongBan { get; set; }
        public int? SoLuongTon { get; set; }
        public int? LuotXem { get; set; }
        public int? LuotBinhChon { get; set; }
        [MaxLength(10)]
        public string? LuotBinhLuan { get; set; }
        public int? Moi { get; set; }
        public bool? DaXoa { get; set; }
    }
}
