using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class DONDATHANG
    {
        [Key]
        public int MaDDH { get; set; }
        public int? MaKH { get; set; }
        public DateTime? NgayDat { get; set; }
        public bool? TinhTrangGiao { get; set; }
        public DateTime? NgayGiao { get; set; }
        public bool? DaThanhToan { get; set; }
        public int? UuDai { get; set; }
        public bool? DaHuy { get; set; }
        public bool? DaXoa { get; set; }
    }
}
