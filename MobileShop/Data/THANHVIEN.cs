using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class THANHVIEN
    {
        [Key]
        public int MaTV { get; set; }
        public int? MaLTV { get; set; }
        [MaxLength(100)]
        public string? TaiKhoan { get; set; }
        [MaxLength(100)]
        public string? MatKhau { get; set; }
        [MaxLength(255)]
        public string? HoTen { get; set; }
        [MaxLength(255)]
        public string? DiaChi { get; set; }
        [MaxLength(255)]
        public string? Email { get; set; }
        [MaxLength(12)]
        public string? SoDienThoai { get; set; }
        public string? CauHoi { get; set; }
        public string? CauTraLoi { get; set; }

    }
}
