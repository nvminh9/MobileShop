using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class NHACUNGCAP
    {
        [Key]
        public int MaNCC { get; set; }
        [MaxLength(100)]
        public string? TenNCC { get; set; }
        [MaxLength(255)]
        public string? DiaChi { get; set; }
        [MaxLength(255)]
        public string? Email { get; set; }

        [MaxLength(12)]
        public string? SoDienThoai { get; set; }
        [MaxLength(50)]
        public string? Fax { get; set; }
    }
}
