using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class LOAISANPHAM
    {
        [Key]
        public int MaLSP { get; set; }
        [MaxLength(10)]
        public string? TenL { get; set; }
        public string? Icon { get; set; }
        [MaxLength(50)]
        public string? BiDanh { get; set; }
    }
}
