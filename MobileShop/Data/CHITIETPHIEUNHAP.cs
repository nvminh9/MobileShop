using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class CHITIETPHIEUNHAP
    {
        [Key]
        public int MaCTPN { get; set; }
        public int? MaPN { get; set; }
        public int? MaSP { get; set; }
        [Precision(18,0)]
        public decimal? DonGiaNhap { get; set; }
        public int? SoLuongNhap { get; set; }
    }
}
