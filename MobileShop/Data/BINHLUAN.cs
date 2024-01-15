using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data
{
    public class BINHLUAN
    {
        [Key]
        public int MaBL { get; set; }
        public int? MaTV { get; set; }
        public int? MaSP { get; set; }
        public string? NoiDungBL { get; set; }
    }
}
