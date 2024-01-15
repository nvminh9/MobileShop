using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class LOAITHANHVIEN_QUYEN
    {
        [Key]
        public int MaLTV { get; set; }
        [Required]
        [MaxLength(50)]
        public string? MaQuyen { get; set; }
        [MaxLength(50)]
        public string? GhiChu { get; set; }
    }
}
