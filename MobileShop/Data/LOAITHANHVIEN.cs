using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class LOAITHANHVIEN
    {
        [Key]
        public int MaLTV { get; set; }
        [MaxLength(50)]
        public string? TenLoai { get; set; }
        public int? UuDai { get; set; }
    }
}
