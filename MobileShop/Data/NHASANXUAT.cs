using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class NHASANXUAT
    {
        [Key]
        public int MaNSX { get; set; }
        [MaxLength(100)]
        public string? TenNSX { get; set; }
        [MaxLength(255)]
        public string? ThongTin { get; set; }
        public string? Lo { get; set; }
    }
}
