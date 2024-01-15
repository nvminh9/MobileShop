using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class PHIEUNHAP
    {
        [Key]
        public int MaPN { get; set; }
        public int? MaNCC { get; set; }
        public DateTime? NgayNhap { get; set; } 
        public bool? DaXoa { get; set; }
    }
}
