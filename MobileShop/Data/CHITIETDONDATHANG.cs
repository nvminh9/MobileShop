using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class CHITIETDONDATHANG
    {
        [Key]
        public int MaCTDDH { get; set; }
        public int? MaDDH { get; set; }
        public int? MaSP { get; set; }
        public string? TenSP { get; set; }
        public int? SoLuong { get; set; }
        [Precision(18,0)]  
        public decimal? DonGia { get; set; }
    }
}
