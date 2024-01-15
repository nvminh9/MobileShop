using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class KHUYENMAI
    {
        [Key]
        public int MaKhuyenMai { get; set; }
        public string? TenKhuyenMai { get; set; }
        public int? MaSP { get; set; }
        public float? GiamGia { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
