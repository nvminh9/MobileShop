using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class KHACHHANG
    {
        [Key]
        public int MaKH { get; set; }
        public int? MaTV { get; set; }
        [MaxLength(255)]
        public string? TenKH { get; set; }
        [MaxLength(255)]
        public string? DiaChi { get; set; }
        [MaxLength(12)]
        public string? SoDienThoai { get; set; }
    }
}
