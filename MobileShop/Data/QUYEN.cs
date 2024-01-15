using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class QUYEN
    {
        [Key]
        [MaxLength(50)]
        public string MaQuyen { get; set; }
        [MaxLength(50)]
        public string? TenQuyen { get; set; }
    }
}
